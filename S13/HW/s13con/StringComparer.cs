namespace HW;

public class Word
{
    public string word;
    public int WordLength;
}
class MyStringComparer
{
    public static Ordina ordina=new();
    public static OrdinalIgnoreCase ordinalIgnoreCase=new();
}


public class Ordina : IComparer<Word>
{
    public int Compare(Word x, Word y)
    {
        bool Flag=true;
        if (x.WordLength==y.WordLength)
        {
            for (int i = 0; i < x.WordLength; i++)
            {
                if (x.word[i]!=y.word[i])
                {
                    Flag=false;
                    break;
                }
            }
            if(Flag==true)
                return 1;
        }
        return 0;
    }
}

public class OrdinalIgnoreCase : IComparer<Word>
{
    public int Compare(Word x, Word y)
    {
        x.word=x.word.ToLower();
        y.word=y.word.ToLower();
        bool Flag=true;
        if (x.WordLength==y.WordLength)
        {
            for (int i = 0; i < x.WordLength; i++)
            {
                if (x.word[i]!=y.word[i])
                {
                    Flag=false;
                    break;
                }
            }
            if(Flag==true)
                return 1;
        }
        return 0;

    }
};
