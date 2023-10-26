using Newtonsoft.Json;
using ProginovAPITools.Models;
using ProginovAPITools.Models.Price;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Prices
    {
        public List<PriceModel> oPrices { get; set; }
        public bool TimeOut { get; set; }
        public async Task GetPrices(List<PriceRequestModel> prices)
        {
            PriceRequestModelRoot rootRequest = new PriceRequestModelRoot();
            rootRequest.Prices = prices;
            string body = JsonConvert.SerializeObject(rootRequest, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            CRequest<PriceModelRoot> request = new CRequest<PriceModelRoot>();
            await request.PostRequest("/price/bulk", body);
            if (request.m_bTimeOut)
            {
                TimeOut = true;
                oPrices = new List<PriceModel>();
            }
            else if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                PriceModelRoot root = request.FillCOllectionIgnoreNull();
                oPrices = root.Prices;
                TimeOut = false;
            }

            else
            {
                TimeOut = false;
                oPrices = new List<PriceModel>();
            }
        }
    }
}
