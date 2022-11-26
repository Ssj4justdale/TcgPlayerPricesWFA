#pragma warning disable CS0219
#pragma warning disable CS8602

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Policy;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TcgPlayerPricesWFA
{
    internal class TcgParser
    {

        public static string GetCardPriceHistory(string _productID, string _method = "month")
        {
            //https://infinite-api.tcgplayer.com/price/history/284948?range=month
            //https://infinite-api.tcgplayer.com/price/history/284948?range=quarter
            //https://infinite-api.tcgplayer.com/price/history/284948?range=semi-annual
            //https://infinite-api.tcgplayer.com/price/history/284948?range=annual

            using (var client = new HttpClient())
            {
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                var baseAddress = "https://infinite-api.tcgplayer.com/";
                var api = "/price/history/" + _productID + "?range=" + _method;
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Add(contentType);

                //var jsonData = JsonConvert.SerializeObject(myJsonO);
                // var contentData = new StringContent(jsonData, Encoding.UTF8, "application/json");
                //var contentData = new StringContent(myJson, Encoding.UTF8, "application/json");

                var response = client.GetAsync(api).Result;

                //   return response.Content.ToString();
                //   return myJson;

                if (response.IsSuccessStatusCode)
                {
                    var stringData = response.Content.ReadAsStringAsync().Result;
                    return stringData;
                }
                else
                {
                    return "";
                }
            }
         }

        public static string DecipherNameFromTag(string _cardNumber)
        {
            using (var client = new HttpClient())
            {
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                var baseAddress = "http://yugiohprices.com";
                var api = "/api/price_for_print_tag/" + _cardNumber;
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Add(contentType);

                //var jsonData = JsonConvert.SerializeObject(myJsonO);
                // var contentData = new StringContent(jsonData, Encoding.UTF8, "application/json");
                //var contentData = new StringContent(myJson, Encoding.UTF8, "application/json");

                var response = client.GetAsync(api).Result;

                //   return response.Content.ToString();
                //   return myJson;

                if (response.IsSuccessStatusCode)
                {
                    var stringData = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<dynamic>(stringData);
                    return result.data.name.ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        public static string[] SearchCard(string _search)
        {
            bool _foundMatch = false;
            string _setID = "";
            CardSets myCardSets = new CardSets();
            if (_search.Contains("-EN"))
            {
                _foundMatch = true;
                _setID = _search;
                _search = DecipherNameFromTag(_search);
            } else if (myCardSets.ShortCardSetName.ContainsKey(_search) == true)
            {
                _search = myCardSets.ShortCardSetName[_search];
            }
            using (var client = new HttpClient())
            {
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                var baseAddress = "https://mpapi.tcgplayer.com";
                var api = "/v2/search/request?q=" + _search + "&isList=false";
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Add(contentType);

                /*
                var data = new Dictionary<string, string>
                {
                    {"id","72832"},
                    {"name","John"}
                };
                */

                string myJson = "{\r\n  \"algorithm\": \"\",\r\n  \"from\": 0,\r\n  \"size\": 999,\r\n  \"filters\": {\r\n    \"term\": {\r\n      \"productLineName\": [\r\n        \"yugioh\"\r\n      ]\r\n    },\r\n    \"range\": {},\r\n    \"match\": {}\r\n  },\r\n  \"listingSearch\": {\r\n    \"filters\": {\r\n      \"term\": {\r\n        \"sellerStatus\": \"Live\",\r\n        \"channelId\": 0\r\n      },\r\n      \"range\": {\r\n        \"quantity\": {\r\n          \"gte\": 1\r\n        }\r\n      },\r\n      \"exclude\": {\r\n        \"channelExclusion\": 0\r\n      }\r\n    },\r\n    \"context\": {\r\n      \"cart\": {}\r\n    }\r\n  },\r\n  \"context\": {\r\n    \"cart\": {},\r\n    \"shippingCountry\": \"US\"\r\n  },\r\n  \"sort\": {}\n}";


                //var jsonData = JsonConvert.SerializeObject(myJsonO);
                // var contentData = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var contentData = new StringContent(myJson, Encoding.UTF8, "application/json");

                var response = client.PostAsync(api, contentData).Result;

                //   return response.Content.ToString();
                //   return myJson;

                if (response.IsSuccessStatusCode)
                {
                    var stringData = response.Content.ReadAsStringAsync().Result;
                    return new string[] { stringData, _setID , _setID.Split("-")[0] };
                }
                else
                {
                    return new string[] { "", "", "" };
                }
            }
        }
    }
}
