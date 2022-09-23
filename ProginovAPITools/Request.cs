using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class CRequest<T>
    {
        private readonly string m_strApiKey;
        private readonly string m_strApiUrl;
        private readonly string m_strProxyAddress;
        private readonly string m_strProxyUserName;
        private readonly string m_strProxyPassword;
        private WebProxy m_oWebProxy;
        private HttpClientHandler m_httpClientHandler;

        public string m_strSearchResult { get; set; }

        public CRequest()
        {
            m_strApiKey = ConfigurationManager.AppSettings["ApiKey"];
            m_strApiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            m_strProxyAddress = ConfigurationManager.AppSettings["ProxyAddress"];
            m_strProxyUserName = ConfigurationManager.AppSettings["ProxyUsername"];
            m_strProxyPassword = ConfigurationManager.AppSettings["ProxyPassword"];

            ProxyInit();
        }

        private void ProxyInit()
        {
            try
            {
                if (m_strProxyAddress != "" && m_strProxyAddress != null)
                {
                    m_oWebProxy = new WebProxy()
                    {
                        Address = new Uri(m_strProxyAddress),
                        BypassProxyOnLocal = false,
                        UseDefaultCredentials = false
                    };

                    if (m_strProxyUserName != "" && m_strProxyUserName != null && m_strProxyPassword != "" && m_strProxyPassword != null)
                    {
                        NetworkCredential oCredentials = new NetworkCredential(
                            userName: m_strProxyUserName,
                            password: m_strProxyPassword);

                        m_oWebProxy.Credentials = oCredentials;
                    }

                    m_httpClientHandler = new HttpClientHandler()
                    {
                        Proxy = m_oWebProxy
                    };
                }

                else
                {
                    m_httpClientHandler = new HttpClientHandler();
                }
            }

            catch (Exception e)
            {
                string error = "[ERROR] ProxyInit - " + e.Message;
                Console.WriteLine(error);
                Debug.WriteLine(error);
                m_httpClientHandler = null;
                m_oWebProxy = null;
            }
        }


        public async Task GetRequest(string strEndpoint, string strParameters = "")
        {
            try
            {
                if (m_httpClientHandler != null)
                {
                    HttpClient client = new HttpClient(handler: m_httpClientHandler, disposeHandler: true);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("apikey", m_strApiKey);
                    HttpResponseMessage response = await client.GetAsync(m_strApiUrl + strEndpoint + strParameters);
                    if (response.IsSuccessStatusCode)
                    {
                        response.EnsureSuccessStatusCode();
                        m_strSearchResult = await response.Content.ReadAsStringAsync();
                    }
                }
            }

            catch (Exception e)
            {
                string error = "[ERROR] GetRequest (" + strEndpoint + strParameters + ") - " + e.Message;
                Console.WriteLine(error);
                Debug.WriteLine(error);
                m_strSearchResult = "";
            }
        }

        public async Task<byte[]> DownloadFile(string strEndpoint, string strParameters = "")
        {
            try
            {
                if (m_httpClientHandler != null)
                {
                    HttpClient client = new HttpClient(handler: m_httpClientHandler, disposeHandler: true);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("apikey", m_strApiKey);
                    byte[] response = await client.GetByteArrayAsync(m_strApiUrl + strEndpoint + strParameters);
                    return response;
                }
            }

            catch (Exception e)
            {
                string error = "[ERROR] GetRequest (" + strEndpoint + strParameters + ") - " + e.Message;
                Console.WriteLine(error);
                Debug.WriteLine(error);
            }
            return null;
        }

        public async Task PostRequest(string strEndpoint, string jsonBody)
        {
            try
            {
                if (m_httpClientHandler != null)
                {
                    HttpClient client = new HttpClient(handler: m_httpClientHandler, disposeHandler: true);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("apikey", m_strApiKey);
                    HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(m_strApiUrl + strEndpoint, content);
                    if (response.IsSuccessStatusCode)
                    {
                        response.EnsureSuccessStatusCode();
                        m_strSearchResult = await response.Content.ReadAsStringAsync();
                    }
                }
            }

            catch (Exception e)
            {
                string error = "[ERROR] PostRequest (" + strEndpoint + ") - " + e.Message;
                Console.WriteLine(error);
                Debug.WriteLine(error);
                m_strSearchResult = "";
            }
        }

        public async Task PutRequest(string strEndpoint, string jsonBody)
        {
            try
            {
                if (m_httpClientHandler != null)
                {
                    HttpClient client = new HttpClient(handler: m_httpClientHandler, disposeHandler: true);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("apikey", m_strApiKey);
                    HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(m_strApiUrl + strEndpoint, content);
                    if (response.IsSuccessStatusCode)
                    {
                        response.EnsureSuccessStatusCode();
                        m_strSearchResult = await response.Content.ReadAsStringAsync();
                    }
                }
            }

            catch (Exception e)
            {
                string error = "[ERROR] PostRequest (" + strEndpoint + ") - " + e.Message;
                Console.WriteLine(error);
                Debug.WriteLine(error);
                m_strSearchResult = "";
            }
        }

        public T FillCOllectionFromArrayIgnoreNull()
        {

            JArray joResponse = JArray.Parse(m_strSearchResult);
            JArray jObject = (JArray)joResponse;
            return JsonConvert.DeserializeObject<T>(jObject.ToString(), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public T FillCOllectionIgnoreNull()
        {

            JObject joResponse = JObject.Parse(m_strSearchResult);
            JObject jObject = (JObject)joResponse;
            return JsonConvert.DeserializeObject<T>(jObject.ToString(), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}

