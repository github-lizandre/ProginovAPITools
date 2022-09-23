using Newtonsoft.Json;
using ProginovAPITools.Models;
using ProginovAPITools.Models.Price;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Prices
    {
        public List<PriceModel> oPrices { get; set; }
        public async Task GetPrices(List<PriceRequestModel> prices)
        {
            PriceRequestModelRoot rootRequest = new PriceRequestModelRoot();
            rootRequest.Prices = prices;
            string body = JsonConvert.SerializeObject(rootRequest, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            CRequest<PriceModelRoot> request = new CRequest<PriceModelRoot>();
            await request.PostRequest("/price/bulk", body);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                PriceModelRoot root = request.FillCOllectionIgnoreNull();
                oPrices = root.Prices;
            }

            else
            {
                oPrices = new List<PriceModel>();
            }
        }
    }
}
