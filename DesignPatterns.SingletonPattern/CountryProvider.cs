using DesignPatterns.SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class CountryProvider
    {
        private static CountryProvider instance;
        public static CountryProvider Instance => instance ?? (instance = new CountryProvider());
        private new List<Country> Countries { get; set; }

        private CountryProvider()
        {
            Task.Delay(2000).GetAwaiter().GetResult();
            Countries = new List<Country>()
                {
                    new Country(){Name = "Az"},
                    new Country(){Name = "Tr"}
                };
        }

        public int CountryCount => Countries.Count;
        public async Task<List<Country>> GetCountries() => Countries;
    }
}
