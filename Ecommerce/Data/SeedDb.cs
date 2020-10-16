using Ecommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    
        public class SeedDb
        {
            private readonly DataContext _context;

            public SeedDb(DataContext context)
            {
                _context = context;
            }

            public async Task SeedAsync()
            {
                await _context.Database.EnsureCreatedAsync();
                await CheckCountriesAsync();
            }

            private async Task CheckCountriesAsync()
            {
                if (!_context.Countries.Any())
                {
                    _context.Countries.Add(new Country
                    {
                        Name = "Honduras",
                        Cities = new List<City>
                {
                    new City
                    {
                        Name = "Tegucigalpa",                     
                    },
                    new City
                    {
                        Name = "San Pedro Sula",                       
                    },
                    new City
                    {
                        Name = "La Ceiba",                        
                    }
                }
                    });
                    _context.Countries.Add(new Country
                    {
                        Name = "Estados Unidos",
                        Cities = new List<City>
                {
                    new City
                    {
                        Name = "Los Angeles",                        
                    },
                    new City
                    {
                        Name = "Chicago",                       
                    }
                }
                    });
                    await _context.SaveChangesAsync();
                }
            }
        }

    }

