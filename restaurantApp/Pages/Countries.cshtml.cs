using Microsoft.AspNetCore.Mvc.RazorPages;
using restaurantApp.Data;

namespace restaurantApp.Pages
{
    public class CountriesModel : PageModel
    {

        public List<CountryModel> fakeCountryDb = new()
        {
            new CountryModel(){Name="Georgia"},
            new CountryModel(){Name="Poland"}
        };
        public void OnGet()
        {
        }
    }
}
