using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using ASYNC_front1.Models.Interfaces;

namespace ASYNC_front1.Models.Services
{
    public class HotelService : IHotelManager
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<Hotel>> GetAllHotels()
        {
            var baseUrl = @"https://async-inntdcb.azurewebsites.net/api";
            string route = "hotel";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var streamTask = await client.GetStreamAsync($"{baseUrl}/{route}");
            // converted to C# from JSON
            var result = await JsonSerializer.DeserializeAsync<List<Hotel>>(streamTask);

            return result;
            throw new NotImplementedException();
        }

        public Task GetHotelByID()
        {
            throw new NotImplementedException();
        }
    }
}
