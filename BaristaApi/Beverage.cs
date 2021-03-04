using System.Collections.Generic;

public interface IBeverage
{
    List<string> Ingredients { get; }
    string CupType { get; }
}

public class Espresso : IBeverage
{
    public List<string> Ingredients => new()
    {
        "Base"
    };

    public string CupType => "Small";
}

public class Latte : IBeverage
{
    public List<string> Ingredients => new()
    {
        "Base",
        "Milk"
    };

    public string CupType => "Medium";
}

public class Mocha : IBeverage
{
    public List<string> Ingredients => new()
    {
        "Base",
        "Chocolate Syrup",
        "Milk"
    };

    public string CupType => "Medium";
}

public class Macchiato : IBeverage
{
    public List<string> Ingredients => new()
    {
        "Base",
        "Milk foam"
    };

    public string CupType => "Medium";
}

public class Americano : IBeverage
{
    public List<string> Ingredients => new()
    {
        "Base",
        "Water"
    };

    public string CupType => "Large";
}


public class Cappuccino : IBeverage
{
    public List<string> Ingredients => new()
    {
        "Base",
        "Milk",
        "Milk foam"
    };

    public string CupType => "Large";
}

public class FelixSpeziale : IBeverage
{
    public List<string> Ingredients => new()
    {
        "Base",
        "Alcohol",
        "Cream"
    };

    public string CupType => "Extra Large";
}