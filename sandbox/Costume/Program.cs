namespace Costume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Costume World!");
        Console.WriteLine("");
        List<Costume> myCostumes = new List<Costume>();
        Costume detective = new Costume(); 

        //add detective wardrobe
        detective._headwear = "fedora";
        detective._upperGarment = "trench coat";
        detective._lowerGarment = "slacks";
        detective._footWear = "dress shoes";
        detective._accessories = "magnifying glass";
        myCostumes.Add(detective);
        //adds snorkeler wardrobe
        Costume snorkeler = new Costume();

        snorkeler._headwear = "googles";
        snorkeler._upperGarment = "wetsuit shirt";
        snorkeler._lowerGarment = "wetsuit pants";
        snorkeler._footWear = "flippers";
        snorkeler._accessories = "snorkel";
        myCostumes.Add(snorkeler);

        foreach (Costume c in myCostumes)
        {
            c.Output();
        }
    }
}
