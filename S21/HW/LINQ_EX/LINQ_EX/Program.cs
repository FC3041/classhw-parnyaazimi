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
                        .ToList()
                        .ForEach(t=>System.Console.WriteLine(t));
        Console.WriteLine();

        //Query 2
        Console.WriteLine("Query 2");
        var data1=File.ReadAllLines("data.csv")
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
                        .ToList();
        data1.Join(data1,
                   (d1)=>d1.country,
                   (d2)=>d2.country,
                   (d1,d2)=>(country:d1.country,DisplayValued1:d1.DisplayValue, DisplayValued2:d2.DisplayValue))
        .GroupBy(t=>t.country)  
        .Select
        (
            g=>
            {
                var maxdiff = g.MaxBy(t=>Math.Abs(t.DisplayValued1-t.DisplayValued2));
                return (country:g.Key, diff:Math.Abs(maxdiff.DisplayValued2-maxdiff.DisplayValued1));                
            }
        )
        .OrderBy(t=>t.diff)
        .ToList()
        .ForEach(l=>System.Console.WriteLine((l)));
              
        Console.WriteLine();

        //Query 3
        Console.WriteLine("Query 3");
        File.ReadAllLines("data.csv")
                        .Skip(1)
                        .Select(l=>Data.Parse(l))
                        .Where
                        (
                            l =>
                                l.LEType==LifeExpectancyType.AtBirth &&
                                l.DataGender==DataGender.Both
                        )
                        .GroupBy(t=>t.Country)
                        .Select
                        (
                            g=>
                            {
                                var min = g.OrderBy(t => t.Value).First();
                                var max = g.OrderBy(t => t.Value).Last();
                                return(
                                       country:g.Key,
                                       year:min.Year,
                                       minValue:min.Value,
                                       diff:Math.Abs(min.Value-max.Value));
                            }
                        )
                        .OrderBy(t=>t.diff)
                        .ToList()
                        .ForEach(t=>System.Console.WriteLine(t));
        Console.WriteLine();

        //Query 4
        Console.WriteLine("Query 4");
        var data4=File.ReadAllLines("data.csv")
                        .Skip(1)
                        .Select(l=>Data.Parse(l))
                        .Where(l =>l.LEType==LifeExpectancyType.AtBirth);
        data4.Join(data4,
                 (d1)=>(d1.Country,d1.Year),
                 (d2)=>(d2.Country,d2.Year),
                 (d1,d2)=>(country:d1.Country, y1:d1.Year, y2:d2.Year, r1:d1.DataGender, r2:d2.DataGender)
        )
        .GroupBy(t=>t.country);
        Console.WriteLine();

    }
}
