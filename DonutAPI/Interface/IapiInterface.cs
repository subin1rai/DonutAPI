using DonutAPI.Model;

namespace DonutAPI.Interface
{
    public interface IapiInterface
    {
        List<Country> GetAllCountries();

        Country GetCountry(int id);
        void AddCountry(Country country);
        void EditCountry(Country country);
        void DeleteCountry(Country country);
    }
}
