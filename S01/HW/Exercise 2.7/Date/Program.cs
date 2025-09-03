namespace Date;
using System;
class Program
{
    //Part6
    public static bool IN(int n,int[] List)
    {
        for (int i = 0; i < List.Length; i++)
        {
            if(n==List[i])
                return true;
        }
        return false;
    }
    public static int Days_in_month0(int monthNumber)
    {
        int[] Day30 = {4,6,9,11};
        if(monthNumber==2)
            return 28;
        else if(IN(monthNumber,Day30))
            return 30;
        else
            return 31;
    }

    //Part7
    public static bool Is_leap_year(int year)
    {
        if ((year % 400 == 0) || (year%4==0 && year%100!=0))
            return true;
        return false;
    }
    public static int Days_in_month1(int year ,int monthnumber)
    {
        int[] Day30={4, 6,9,11};
        if (monthnumber == 2)
        {
            if (Is_leap_year(year))
                return 29;
            else
                return 28;
        }
        else if (Day30.Contains(monthnumber))
            return 30;
        else
            return 31;

    }
    
    //Part8
    public static int Days_before_date(int year,int monthNumber,  int dayNumber)
    {
        int sum=0;
        for (int i = 1; i < monthNumber; i++)
            sum+=Days_in_month1(year,i);
        sum+=dayNumber-1;
        return sum;
    }

    //Part9
    public static string Day_of_the_week(int year,int monthNumber,int dayNumber)
    {
        int days=Days_before_date(year,monthNumber,dayNumber);
        int a=days%7;
        string[] arr={"Monday","Tuesday","Wednesday" ,"Thursday","Friday" ,"Saturday","Sunday"};
        return arr[a];
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Day_of_the_week(2014, 12, 28));
    }
}
