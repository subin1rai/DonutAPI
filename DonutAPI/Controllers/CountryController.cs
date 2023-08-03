using DonutAPI.Data;
using DonutAPI.Interface;
using DonutAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DonutAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller


    {
        private readonly IapiInterface _apiInterface;

        public CountryController(IapiInterface apiInterface)
        {
            _apiInterface = apiInterface;
        }

        [HttpGet("Countries")]
        public IActionResult ListCountry()
        {
            var allcountry = _apiInterface.GetAllCountries();
            return Ok(allcountry);
        }
        [HttpPost("AddCountry")]
        public IActionResult AddCountry(Country country)
        {
            _apiInterface.AddCountry(country);
            return Ok(country);

        }
        [HttpPost("EditCountry")]
        public IActionResult EditCountry(Country country)
        {
            _apiInterface.EditCountry(country);
            return Ok(country);

        }
        [HttpPost("DeleteCountry")]
        public IActionResult DeleteCountry(Country country)
        {
            _apiInterface.DeleteCountry(country);
            return Ok(country);

        }

    }
}
