using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using restaurantApp.Data;

namespace restaurantApp.Pages
{
    public class RestaurantsModel : PageModel
    {

        public List<RestaurantModel> fakeRestaurantDb = new()
        {
            new RestaurantModel(){RestaurantName="saxinkle", Stars=4},
            new RestaurantModel(){RestaurantName="sashaurme", Stars=4}
        }; 
        public void OnGet()
        {
        }
    }
}
