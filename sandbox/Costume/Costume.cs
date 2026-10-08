namespace Costume;

public class Costume
{
    // attributes
    public string _headwear;
    public string _upperGarment;
    public string _lowerGarment;
    public string _footWear;
    public string _accessories;
    //behavior

    public void Output()
    {
        Console.WriteLine("Costume specification:");
        Console.WriteLine($"Head Wear: {_headwear}");
        Console.WriteLine($"Upper Garment: {_upperGarment}");
        Console.WriteLine($"Lower Garment: {_lowerGarment}");
        Console.WriteLine($"Foot Wear: {_footWear}");
        Console.WriteLine($"Accessories: {_accessories}");
        Console.WriteLine(" ");
    }
}

