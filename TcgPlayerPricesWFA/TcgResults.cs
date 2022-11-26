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


public class CardSets
{
    public Dictionary<string, string> ShortCardSetName { get; } = new Dictionary<string, string>()
    {/*
        {"LC03", "legendary-collection-3-yugis-world" },

        {"DP1", "duelist-league-promo" }, {"DP2", "duelist-league-promo" }, {"DP3", "duelist-league-promo" }, {"DP4", "duelist-league-promo" }, {"DP5", "duelist-league-promo" },
        {"DP6", "duelist-league-promo" }, {"DP7", "duelist-league-promo" }, {"DP8", "duelist-league-promo" }, {"DP9", "duelist-league-promo" }, {"DP10", "duelist-league-promo" },
        {"DP11", "duelist-league-promo" }, {"DP12", "duelist-league-promo" },{"DP13", "duelist-league-promo" }, {"DP14", "duelist-league-promo" }, {"DP15", "duelist-league-promo" },
        {"DP16", "duelist-league-promo" }, {"DP17", "duelist-league-promo" }, {"DP18", "duelist-league-promo" }, {"DPDI", "duelist-league-promo" }, {"DL09", "duelist-league-promo" }
   */
    };
}

