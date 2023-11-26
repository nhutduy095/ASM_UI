using Newtonsoft.Json;
using QuanlySV.Configuration;
using QuanlySV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV
{
    internal class CallAPICenter
    {
        public static async Task<ResponseModel> CallAPIPost(dynamic modelRequest, string url)
        {
            string domain = Config.Domain+url;
            //System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            using (HttpClient client = new HttpClient())
            {
                string token = Config.Token;
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(modelRequest), Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("x-token", token);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                try
                {
                    client.Timeout = TimeSpan.FromMinutes(60);

                    var data = await client.PostAsync(domain, httpContent);

                    var jsonResponse = await data.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ResponseModel>(jsonResponse);
                }
                catch (Exception e)
                {
                    return new ResponseModel("Lỗi hệ thống khi call function của IF " + (e.InnerException == null ? e.Message : e.InnerException.Message), "ERR001");
                }
            }
            //return new ResponseModel.ResponseModel();

        }

        public static async Task<ResponseModel> CallAPIGet(string url)
        {
            string domain = Config.Domain + url;
            using (HttpClient client = new HttpClient())
            {
                string token = Config.Token;
                //HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(modelRequest), Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("x-token", token);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                try
                {
                    client.Timeout = TimeSpan.FromMinutes(60);
                    var data = await client.GetAsync(domain);

                    var jsonResponse = await data.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ResponseModel>(jsonResponse);
                }
                catch (Exception e)
                {
                    return new ResponseModel("Lỗi hệ thống khi call function của IF " + (e.InnerException == null ? e.Message : e.InnerException.Message), "ERR001");
                }
            }
            //return new ResponseModel.ResponseModel();

        }
    }
}
