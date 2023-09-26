namespace ImplicitOperators;
    
public class Phone
{
    public static void Testing()
    {
        var phone = new Phone()
        {
            Area = "99",
            CountryCode = "55",
            Number = "88284904"
        };
        Console.WriteLine(phone);

        var number = "+55 (99) 88284904";
        Console.WriteLine(number);
    }
    
    public string CountryCode { get; set; }
    public string Area { get; set; }
    public string Number { get; set; }

    public static implicit operator string(Phone phone) =>
        $"+{phone.CountryCode} ({phone.Area}) {phone.Number}";

    public static implicit operator Phone(String ph)
    {
        // var splited = ph.
        var data  = ph.Split(" ");
        return new Phone()
        {
            CountryCode = data[0],
            Area = data[1],
            Number = data[2]
        };
    }
    
    // public override string ToString()
    // {
    //     if (
    //         String.IsNullOrEmpty(CountryCode)||
    //         String.IsNullOrEmpty(Area) ||
    //         String.IsNullOrEmpty(Number) ) return "Não definido";
    //     return $"+{CountryCode} ({Area}) {Number}";
    // }
}

