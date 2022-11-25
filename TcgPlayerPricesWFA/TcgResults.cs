// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
//#pragma warning disable RCS1194
#pragma warning disable CS8618


// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Result
{
    public string date { get; set; }
    public List<Variant> variants { get; set; }
}

public class Root
{
    public int count { get; set; }
    public List<Result> result { get; set; }
}

public class Variant
{
    public string averageSalesPrice { get; set; }
    public string marketPrice { get; set; }
    public string quantity { get; set; }
    public string variant { get; set; }
}

