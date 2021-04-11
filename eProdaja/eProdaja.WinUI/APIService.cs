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
        //Sve funkcije iz kontrolera
        //Get, GetById, Insert, Update

        //Rješenje problema 1.
        private string _route;

        public APIService(string route)
        {
            _route = route;
        }

        //PROBLEMI:
        //1. hard kodirani naziv kontrolera - dodati property da bi znali koji se kontroler koristi
        //2. Izbaciti hard kodiranu putanju - dodati setting
        //3. Riješiti problem sinhronih poziva - asinhroni pozivi
        /*public T Get<T>()
        {
            var result = "https://localhost:5001/api/nazivKontrolera".GetJsonAsync<T>().Result;
            return result;
        }*/

        public async Task<T> Get<T>(object request)
        {
            //Svako mjesto poziva mora imati await, svaka funkcija koja poziva mora biti async
            //var result = await $"{Properties.Settings.Default.ApiURL}/{_route}".GetJsonAsync<T>();

            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            if (request != null)
                url += "?" + await request.ToQueryString();
            
            var result = await url.GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.PostJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
