namespace HW;

class Program
{
    public static void ReverseWord(string str, out string strrev)
    {
        strrev="";
        foreach (char item in str)
        {
            strrev=item + strrev;
        }
    }

    public static void ReverseSentence(string str,out string strrev)
    {
        List<string> WordList=new List<string>{};
        strrev="";
        string Word="";
        for (int i=0; i<=str.Length;i++)
        {
            if (i<str.Length && str[i]!=' ' && str[i]!='\0')
            {
                Word+=str[i];
            }
            else if(i==str.Length || str[i]==' ' || str[i]=='\0' )
            {
                WordList.Add(Word);
                if(i!=str.Length)
                    WordList.Add(" ");
                // System.Console.WriteLine(Word);
                Word="";
            }
        }
        foreach (string item in WordList)
        {
            strrev=item+strrev;
        }
    }


    public static void ReverseSentence_Word(string str,out string strrev)
    {
        List<string> WordList=new List<string>{};
        strrev="";
        string Word="";
        for (int i=0; i<=str.Length;i++)
        {
            if (i<str.Length && str[i]!=' ' && str[i]!='\0')
            {
                Word+=str[i];
            }
            else if(i==str.Length || str[i]==' ' || str[i]=='\0' )
            {
                string WordRev;
                ReverseWord(Word,out WordRev);
                WordList.Add(WordRev);
                if(i!=str.Length)
                    WordList.Add(" ");
                // System.Console.WriteLine(Word);
                Word="";
            }
        }
        foreach (string item in WordList)
        {
            strrev=item+strrev;
        }        
    }

    static void Main(string[] args)
    {
        string stringout;
        ReverseWord("Parnya",out stringout);
        Console.WriteLine(stringout);

        string stringout2;
        ReverseSentence("My name is Parnya",out stringout2);
        Console.WriteLine(stringout2);

        string stringout3;
        ReverseSentence_Word("My name is Parnya",out stringout3);
        Console.WriteLine(stringout3);
    }

}
