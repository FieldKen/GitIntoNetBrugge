Console.WriteLine("Eerste git push! {0} {1} {2}","ABC", "DEF", "GHI");

public static class Extensions
{   
    public static void Optellen(ref this int getal1, int getal2)
    {
        getal1 += getal2;
    }
}