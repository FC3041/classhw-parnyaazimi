namespace HW;

public static class Extention
{
    public static string Encoder(this string str)
    {
        string result = "";
        foreach (char item in str)
        {
            if (char.IsLower(item))
            {       
                int Intcahr = (int)item;
                Intcahr += 3;
                if (Intcahr > 122)
                    Intcahr -= 26;
                result += (char)Intcahr;
            }
            else if (char.IsUpper(item))
            {       
                int Intcahr = (int)item;
                Intcahr += 3;
                if (Intcahr > 90)
                    Intcahr -= 26;
                result += (char)Intcahr;
            }
            else
                result += item;
            
        }
        return result;
    }

    public static string Decoder(this string str)
    {
        string result = "";
        foreach (char item in str)
        {
            if (char.IsLower(item))
            {       
                int Intcahr = (int)item;
                Intcahr -= 3;
                if (Intcahr < 97)
                    Intcahr += 26;
                result += (char)Intcahr;
            }
            else if (char.IsUpper(item))
            {       
                int Intcahr = (int)item;
                Intcahr -= 3;
                if (Intcahr < 65)
                    Intcahr += 26;
                result += (char)Intcahr;
            }
            else
                result += item;
        }
        return result;
    }
}
