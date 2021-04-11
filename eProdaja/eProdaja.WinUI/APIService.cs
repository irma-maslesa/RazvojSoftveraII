using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using eProdaja.Model;

namespace eProdaja.WinUI
{
    //klasa za komunikaciju sa APIjem
    public class APIService
    {
        private string _route;
        public string _apiUrl = Properties.Settings.Default.ApiURL;

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object request)
        {

            var url = $"{_apiUrl}/{_route}";
            if (request != null)
                url += "?" + await request.ToQueryString();
            
            var result = await url.GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            var result = await url.GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";
            var result = await url.PostJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            var result = await url.PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
