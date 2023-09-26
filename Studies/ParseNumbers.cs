namespace ParseNumbers;

public class ParseNumbers
{
    public static void Testing()
    {
        var intString = "34";
        int converted;
        
        Console.WriteLine(int.TryParse(intString, out converted));
        Console.WriteLine(converted);
    }
}