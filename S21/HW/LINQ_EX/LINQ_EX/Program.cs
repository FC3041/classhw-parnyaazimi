using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string? Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Query 1
        Console.WriteLine("Query 1");
        File.ReadAllLines("data.csv")
                        .Skip(1)
                        .Select(l=>Data.Parse(l))
                        .Where
                        (
                            l => 
                                l.Country.ToLower().Contains("iran") &&
                                l.LEType==LifeExpectancyType.AtBirth &&
                                l.DataGender==DataGender.Both
                        )
                        .Select
                        (
                            l=>
                            {
                                return(country:l.Country,Indicator:l.LEType,Gender:l.DataGender,year:l.Year,DisplayValue:l.Value);
                            }
                        )
                        .OrderBy(t=>t.DisplayValue)
                        .ToList()
                        .ForEach(t=>Console.WriteLine(t));
        Console.WriteLine();

        // //Query 2
        Console.WriteLine("Query 2");
        File.ReadAllLines("data.csv")
                        .Skip(1)
                        .Select(l=>Data.Parse(l))
                        .Where
                        (
                            l => 
                                l.Country.ToLower().Contains("iran") &&
                                l.LEType==LifeExpectancyType.AtBirth &&
                                l.DataGender==DataGender.Both
                        )
                        .Select
                        (
                            l=>
                            {
                                return(country:l.Country,Indicator:l.LEType,Gender:l.DataGender,year:l.Year,DisplayValue:l.Value);
                            }
                        )
                        .GroupBy(t=>t.country)
                        .Select
                        (
                            g=>
                            {
                                var min=g.MinBy(t=>t.DisplayValue);
                                var max=g.MaxBy(t=>t.DisplayValue);
                                return Math.Abs(min.DisplayValue-max.DisplayValue);                                
                            }
                        )
                        .ToList()
                        .ForEach(n=>Console.WriteLine(n));
              
        Console.WriteLine();

        // Query 3
        Console.WriteLine("Query 3");
        File.ReadAllLines("data.csv")
            .Skip(1)
            .Select(l=>Data.Parse(l))
            .Where(dt=>dt.DataGender==DataGender.Both && dt.LEType==LifeExpectancyType.AtBirth)
            .GroupBy(dt=>dt.Country)
            .Select
            (
                (g,Index)=>
                {
                    var min=g.MinBy(t=>t.Value);
                    var max=g.MaxBy(t=>t.Value);
                    return(Index+1,country:g.Key , year:min.Year , minValu:min.Value , diff: Math.Abs(min.Value-max.Value));
                }
            )
            .ToList()
            .ForEach(dt=>System.Console.WriteLine(dt));
        Console.WriteLine();




        //Query 4
        Console.WriteLine("Query 4");
        File.ReadAllLines("data.csv")
                    .Skip(1)
                    .Select(l=>Data.Parse(l))
                    .Where(l =>l.LEType==LifeExpectancyType.AtBirth)
                    .GroupBy(l=>new { l.Year, l.Country })
                    .Select
                    (
                        g=>
                        {
                            var IsMale=g.FirstOrDefault(l=>l.DataGender==DataGender.Male);
                            var IsFeMale=g.FirstOrDefault(l=>l.DataGender==DataGender.Female);
                            return(country:IsMale.Country, 
                                   year:IsMale.Year, 
                                   ValueFemale:IsFeMale.Value, 
                                   ValueMale:IsMale.Value,
                                   diff:Math.Abs(IsMale.Value-IsFeMale.Value));
                        }
                    )
                    .GroupBy(t=>t.country)
                    .Select
                    (
                        g=>
                        {
                            return g.OrderByDescending(t=>t.diff).First();
                        }
                    )
                    .OrderByDescending(t=>t.diff)
                    .Select
                    (
                        (t, index) =>(index + 1,t.country,t.year,t.ValueMale,t.ValueFemale,t.diff)
                    )
                    .ToList()
                    .ForEach(t=>System.Console.WriteLine(t));
        Console.WriteLine();

    }
}
