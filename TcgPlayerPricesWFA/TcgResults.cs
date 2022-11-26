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
    {
        {"CP01", "Champion Pack: Game 1" }, {"CP02", "Champion Pack: Game 2" }, {"CP03", "Champion Pack: Game 3" }, {"CP04", "Champion Pack: Game 4" },
        {"CP05", "Champion Pack: Game 5" }, {"CP06", "Champion Pack: Game 6" }, {"CP07", "Champion Pack: Game 7" }, {"CP08", "Champion Pack: Game 8" },

        {"CT1", "2004 Collectors Tin" }, {"CT2", "2005 Collectors Tin" }, {"CT03", "2005 Collectors Tin" }, {"CT04", "2007 Collectors Tin" },
        {"CT05", "2008 Collectors Tin" }, {"CT06", "2009 Collectors Tin" }, {"CT07", "2010 Collectors Tin" }, {"CT08", "2011 Collectors Tin" },
        {"CT09", "2012 Collectors Tin" }, {"CT11", "2014 Mega-Tin" }, {"CT12", "2015 Mega-Tin" }, {"CT13", "2016 Mega-Tin" },
        {"CT14", "2017 Mega-Tin" }, {"CT15", "2018 Mega-Tin" },


        {"PRC1", "2012 Premium Collection Tin" },
        {"ZTIN", "2013 Zexal Collection Tin" },

        {"MP14", "2014 Mega-Tin Mega Pack" }, {"MP15", "2015 Mega-Tin Mega Pack" }, {"MP16", "2016 Mega-Tin Mega Pack" }, {"MP17", "2017 Mega-Tin Mega Pack" },
        {"MP18", "2018 Mega-Tin Mega Pack" }, {"MP19", "2019 Gold Sarcophagus Mega Pack" }, {"MP20", "2020 Tin of Lost Memories" }, {"MP21", "2021 Tin of Ancient Battles" },
        {"MP22", "2022 Tin of the Pharaoh's Gods Mega Pack" },


        {"TN19", "2019 Gold Sarcophagus Tin Promos" },


        {"25TH", "25th Anniversary Promo Card" },


        {"TF05", "5D's Tag Force 5" },


        {"WC5", "7 Trials to Glory: World Championship Tournament 2005" },

        {"ABPF", "Absolute Powerforce" },
        {"ABYR", "Absolute Powerforce" },


        {"ANGU", "Ancient Guardians" },
        {"ANPR", "Ancient Prophecy" },
        {"AST", "Ancient Sanctuary" },


        {"AP01", "Astral Pack 1" }, {"AP02", "Astral Pack 2" }, {"AP03", "Astral Pack 3" }, {"AP04", "Astral Pack 4" },
        {"AP05", "Astral Pack 5" }, {"AP06", "Astral Pack 6" }, {"AP07", "Astral Pack 7" }, {"AP08", "Astral Pack 8" },

        {"BACH", "Battle of Chaos" },

        {"BP01", "Battle Pack: Epic Dawn" }, {"BP02", "Battle Pack 2: War of the Giants" }, {"BP03", "Battle Pack 3: Monster League" },

        {"BPT", "Booster Pack Tins" },


        {"BLAR", "Battles of Legend: Armageddon" },
        {"BLCR", "Battles of Legend: Crystal Revenge" },
        {"BLHR", "Battles of Legend: Hero's Revenge" },
        {"BLLR", "Battles of Legend: Light's Revenge" },
        {"BLRR", "Battles of Legend: Relentless Revenge" },
        {"BOSH", "Breakers of Shadow" },
        {"BROL", "Breakers of Shadow" },
        {"BODE", "Burst of Destiny" },

        {"CHIM", "Chaos Impact" },
        {"CIBR", "Chaos Impact" },

        {"CBLZ", "Clash of Rebellions" },

        {"CMC", "Burst of Destiny" },
        {"CORE", "Clash of Rebellions" },
        {"COTD", "Clash of Rebellions" },
        {"CRMS", "Crimson Crisis" },
        {"CROS", "Crossed Souls" },
        {"CSOC", "Crossroads of Chaos" },


        {"BPW2", "Battle Pack 2: War of the Giants Round 2" },

        {"SD3", "Blaze of Destruction" },

        {"BLVO", "Blazing Vortex" },


        {"SDAZ", "Albaz Strike" },
        {"SDCR", "Cyber Dragon Revolution" },
        {"SDCS", "Cyber Strike" },
        {"SDIP", "Cyberdark Impact" },
        {"CYHO", "Cybernetic Horizon" },
        {"CRV", "Cybernetic Revolution" },

        {"DB1", "Dark Beginnings" },
        {"DB2", "Dark Beginnings" },

        {"DCR", "Dark Crisis" },
        {"DDS","Dark Duel Stories" },

        {"SDDE", "Dark Emperor" },
        {"DLG1", "Dark Legends" },

        {"YS15", "Dark Legion" },
        {"DANE", "Dark Neostorm" },

        {"DR1", "Dark Revelations" },
        {"DR2", "Dark Revelations" },
        {"DR3", "Dark Revelations" },
        {"DR04", "Dark Revelations" },
        {"DASA", "Dark Saviors" },
        {"DABL", "Darkwing Blast" },


        { "MAMA", "Magnificent Mavens" }
    };
}

