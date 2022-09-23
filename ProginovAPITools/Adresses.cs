using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProginovAPITools.Models.Adresses;
using Newtonsoft.Json;

namespace ProginovAPITools
{
    public class Adresses
    {
        public List<AdresseModel> oAdresses { get; set; }
        public async Task LoadAdresses(int CodeTiers)
        {
            CRequest<AdressesModelRoot> request = new CRequest<AdressesModelRoot>();
            await request.GetRequest("/adresse/customer/", CodeTiers.ToString());
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                AdressesModelRoot root = request.FillCOllectionIgnoreNull();
                oAdresses = root.Adresses;
            }

            else
            {
                oAdresses = new List<AdresseModel>();
            }
        }

        public async Task<AdresseSuccessRoot> AddAdresse(AdresseModel adresse)
        {
            AdresseModelRoot rootBody = new AdresseModelRoot();
            rootBody.Adresse = adresse;
            CRequest<AdresseSuccessRoot> request = new CRequest<AdresseSuccessRoot>();
            string body = JsonConvert.SerializeObject(rootBody, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            await request.PostRequest("/adresse/customer/", body);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                AdresseSuccessRoot root = request.FillCOllectionIgnoreNull();
                return root;
            }

            else
            {
                return new AdresseSuccessRoot();
            }
        }

        public async Task<AdresseSuccessRoot> UpdateAdresse(AdresseModel adresse)
        {
            AdresseModelRoot rootBody = new AdresseModelRoot();
            rootBody.Adresse = adresse;
            CRequest<AdresseSuccessRoot> request = new CRequest<AdresseSuccessRoot>();
            string body = JsonConvert.SerializeObject(rootBody, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            await request.PutRequest("/adresse/customer/", body);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                AdresseSuccessRoot root = request.FillCOllectionIgnoreNull();
                return root;
            }

            else
            {
                return new AdresseSuccessRoot();
            }
        }

        public async Task<List<PaysModel>> GetListePays()
        {
            CRequest<PaysModelRoot> request = new CRequest<PaysModelRoot>();
            await request.GetRequest("/country");
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                PaysModelRoot root = request.FillCOllectionIgnoreNull();
                return root.Pays;
            }

            else
            {
                return new List<PaysModel>();
            }
        }
    }
}
