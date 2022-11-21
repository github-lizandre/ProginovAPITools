using Newtonsoft.Json;
using ProginovAPITools.Models.Commande;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Order
    {
        public List<OrderModel> oOrders { get; set; }
        public async Task LoadOrders(string code_client, string dateDebut, string dateFin)
        {
            CRequest<OrderModelRoot> request = new CRequest<OrderModelRoot>();
            string filterDate = "?filter=[dat_cde|" + dateDebut + "," + dateFin + "]";
            await request.GetRequest("/order/customer/" + code_client + filterDate);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                OrderModelRoot root = request.FillCOllectionIgnoreNull();
                oOrders = root.Orders;
            }
            else
            {
                oOrders = new List<OrderModel>();
            }
        }

        public async Task<OrderModel> LoadSingleOrder(int num_commande)
        {
            CRequest<OrderModelRoot> request = new CRequest<OrderModelRoot>();
            string fields = "|refext,no_ligne,cod_pro,nom_pro,qte,px_vte,remise1,mt_ht,devise,px_net,rem_app";
            await request.GetRequest("/order/" + num_commande.ToString() + "?lignes=true&fields=" + fields);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                OrderModelRoot root = request.FillCOllectionIgnoreNull();
                if (root.Orders.Count > 0)
                {
                    return root.Orders.First();
                }
            }
            return new OrderModel();
        }

        public async Task<CreateOrderSuccess> CreateOrder(CreateOrderModel orderModel)
        {
            CreateOrderModelRoot rootRequest = new CreateOrderModelRoot
            {
                Order = orderModel
            };
            string body = JsonConvert.SerializeObject(rootRequest, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            CRequest<CreateOrderSuccessRoot> request = new CRequest<CreateOrderSuccessRoot>();
            await request.PostRequest("/order", body);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                CreateOrderSuccessRoot root = request.FillCOllectionIgnoreNull();
                return root.Success;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<OrderLignes>> GetReliquats(string code_client)
        {
            CRequest<OrderLignesRoot> request = new CRequest<OrderLignesRoot>();
            string filter = "?filter=[cod_cli|" + code_client + "]&filter=[reliquat|yes]&filter=[no_bl|0]&fields=refext,no_ligne,cod_pro,nom_pro,qte,px_vte,remise1,mt_ht,devise,px_net,rem_app,spe_marque_tec,no_cde";
            await request.GetRequest("/order-lines/" + filter);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                OrderLignesRoot root = request.FillCOllectionIgnoreNull();
                if (root.Lignes.Count > 0)
                {
                    return root.Lignes;
                }
            }
            return new List<OrderLignes>();
        }

        public async Task<byte[]> GetBL(string num_bl, string code_client)
        {
            CRequest<OrderLignesRoot> request = new CRequest<OrderLignesRoot>();
            byte[] response =  await request.DownloadFile("/document/deliveryform/" + num_bl + "/" + code_client);
            return response;
        }

        public async Task<byte[]> GetFacture(string num_fac, string code_client)
        {
            CRequest<OrderLignesRoot> request = new CRequest<OrderLignesRoot>();
            byte[] response = await request.DownloadFile("/document/invoice/" + num_fac + "/" + code_client);
            return response;
        }
    }
}
