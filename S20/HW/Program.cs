namespace HW;

class Program
{
    static void Main(string[] args)
    {

        string Word="Parnya:)";
        System.Console.WriteLine(Word);
        string WordEn=Word.Encoder();
        System.Console.WriteLine(WordEn);
        string WordDn=WordEn.Decoder();
        System.Console.WriteLine(WordDn);
    }
}
