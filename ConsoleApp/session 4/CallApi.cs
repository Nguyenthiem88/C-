﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.session_4
{
    internal class CallApi
    {
        public async Task<Product> FetchData()
        {
            string url = "https://dummyjson.com/products/1";

            HttpClient client= new HttpClient();
            var rs = await client.GetAsync(url);
            if(rs.StatusCode==HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                Product p = Jon
            }
        }
    }
}
