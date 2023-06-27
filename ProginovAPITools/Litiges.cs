using ProginovAPITools.Models.Litiges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Litiges
    {
        public bool TimeOut { get; set; }
        public async Task<List<TypeLitigeModel>> GetListTypeLitiges()
        {
            CRequest<TypeLitigeModelRoot> request = new CRequest<TypeLitigeModelRoot>();
            await request.GetRequest("/litige/famille?fields=a_tab,inti_tab");
            if (request.m_bTimeOut)
            {
                TimeOut = true;
                return new List<TypeLitigeModel>();
            }
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                TimeOut = false;
                TypeLitigeModelRoot root = request.FillCOllectionIgnoreNull();
                return root.TypeLitiges;
            }

            TimeOut = false;
            return new List<TypeLitigeModel>();
        }

        public async Task<List<MotifLitigeModel>> GetListMotifLitiges()
        {
            CRequest<MotifLitigeModelRoot> request = new CRequest<MotifLitigeModelRoot>();
            await request.GetRequest("/litige/motif?filter=[fct_com|yes]&fields=a_tab,inti_tab,zta1,zal1");
            if (request.m_bTimeOut)
            {
                TimeOut = true;
                return new List<MotifLitigeModel>();
            }
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                TimeOut = false;
                MotifLitigeModelRoot root = request.FillCOllectionIgnoreNull();
                return root.MotifLitiges;
            }

            TimeOut = false;
            return new List<MotifLitigeModel>();
        }

        public async Task<List<LitigeModel>> GetListLitigeForCustomer(string customerId, string referenceProduit=null, string dateFromFilter=null, string dateToFilter=null)
        {
            CRequest<LitigeModelRoot> request = new CRequest<LitigeModelRoot>();
            string urlRequest = "/litigetvi/" + customerId;
            //Filtre par reference
            if (referenceProduit != null)
            {
                urlRequest += "/reference/" + referenceProduit;
            }
            //Filtre par date
            if (dateFromFilter != null)
            {
                urlRequest += "?filter=[dat_lit|" + dateFromFilter;
                if (dateToFilter != null)
                    urlRequest += dateToFilter;
                else
                    urlRequest += "%";
                urlRequest += "]";
            }
            await request.GetRequest(urlRequest);
            if (request.m_bTimeOut)
            {
                TimeOut = true;
                return new List<LitigeModel>();
            }
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                TimeOut = false;
                LitigeModelRoot root = request.FillCOllectionIgnoreNull();
                return root.Litiges;
            }

            TimeOut = false;
            return new List<LitigeModel>();
        }


    }
}
