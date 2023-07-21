namespace ConsoleApp1;

enum State
{
    UT ,
    NV,
    TX,
    NY
}
public class Purchase
{
    public static int ApplyDiscount(double price)
    {
        if (price >= 50000)
            return 15;
        if (price >= 10000)
            return 10;
        if (price >= 7000)
            return 7;
        if (price >= 5000)
            return 5;
        if (price >= 1000)
            return 3;
        return 0;
    }

    public static Double ApplyTva(string? state)
    {

        switch (state!.ToLower())
        {
            case "ut":
                return 6.85;
            case "nv":
                return 8.0;
            case "tx":
                return 6.25;
            case "al":
                return 4;
            case "ca":
                return 8.25;
            default:
                return 0;
        }
    }
}
