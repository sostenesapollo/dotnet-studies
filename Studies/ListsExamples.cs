namespace Studies;

public class ListsExamples
{
    public static void Testing()
    {
        List<string> codes = new List<string>();
        
        codes.Add("1");
        codes.Add("2");
        codes.Add("3");

        var car = new Car()
        {
            color = "red",
            year = "2020",
            codes = codes
        };
        
        Console.WriteLine(car.codes.Count);
        foreach (var code in car.codes)
        {
            Console.WriteLine(code);
        }
    }
}

public class Car
{
    public string year;
    public string color;
    public List<string> codes;
}