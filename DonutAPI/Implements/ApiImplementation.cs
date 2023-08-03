using DonutAPI.Data;
using DonutAPI.Interface;
using DonutAPI.Model;

namespace DonutAPI.Implements
{
    public class ApiImplementation: IapiInterface


    {
        private readonly CheckDbContext _context;
        public ApiImplementation(CheckDbContext context) {
            _context = context;
        }

        public void AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }

        public void DeleteCountry(Country country)
        {
            _context.Countries.Remove(country);
            _context.SaveChanges();
        }

        

        public void EditCountry(Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
        }

        public List<Country> GetAllCountries()
        {
            var allCountry = _context.Countries.ToList();
            return allCountry;
        }

        public Country GetCountry(int id)
        {
            var idcountry = _context.Countries.Find(id);
            return idcountry;
        }
    }
}
