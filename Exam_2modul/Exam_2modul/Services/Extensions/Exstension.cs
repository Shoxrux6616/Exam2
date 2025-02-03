namespace Exam_2modul.Services.Extensions;

public class Exstension
{
    public static double DisanceKm(this double Km)
    {
        return Km * 0.621371;
    }

    public static double Prices(this double price)
    {
        var res = 0;    
        if (price > 0)
        {
            res++;
        }
        return res;
    } 
}
