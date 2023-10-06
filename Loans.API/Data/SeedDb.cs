using Loans.Shared.Entities;

namespace Loans.API.Data
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
                    Name = "Colombia",
                    States = new List<State>()
                    {
                        new State()
                        {
                            Name= "Antioquia",
                            Cities= new List<City>()
                            {
                                new City(){Name = "Medellin"},
                                new City(){Name = "Bello"},
                                new City(){Name = "Copacabana"},
                                new City(){Name = "Rionegro"},
                                new City(){Name = "Envigado"},
                            }
                        },
                        new State ()
                        {
                            Name="Bogota",
                            Cities= new List<City>()
                            {
                                new City() {Name="Usaquen"},
                                new City() {Name="Champinero"},
                                new City() {Name="Santa fe"},
                                new City() {Name="Useme"},
                                new City() {Name="Bosa"},
                            }
                        },
                    }
                });
                _context.Countries.Add(new Country 
                { 
                    Name = "Perú" ,
                    States= new List<State>()
                    {
                        new State()
                        {
                            Name="Lima",
                            Cities= new List<City>() 
                            {
                                new City() { Name="Cercado de Lima"},
                                new City() { Name="Breña"},
                                new City() { Name="Comas"},
                                new City() { Name="Lurigancho Chosica"},
                                new City() { Name="Vitarte"},
                                new City() { Name="El Agustino"},
                                new City() { Name="Lima"},
                            }
                        },
                        new State()
                        {
                            Name="Ayacucho",
                            Cities= new List<City>()
                            {
                                new City() { Name="Huamanga"},
                                new City() { Name="Huanta" },
                                new City() { Name="Cangallo"},
                            }
                        }
                    }
                });

                _context.Countries.Add(new Country { Name = "México" });
                _context.Countries.Add(new Country { Name = "Argentina" });
                _context.Countries.Add(new Country { Name = "Brazil" });
                _context.Countries.Add(new Country { Name = "Chile" });
                _context.Countries.Add(new Country { Name = "Bolivia" });
                _context.Countries.Add(new Country { Name = "Venezuela" });
                _context.Countries.Add(new Country { Name = "Replubica Dominicana" });
                await _context.SaveChangesAsync();
            }
        }
    }
}

