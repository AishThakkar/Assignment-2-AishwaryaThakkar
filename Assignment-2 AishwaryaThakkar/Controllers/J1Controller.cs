using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2_AishwaryaThakkar.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculate the total calories of a meal at Chip's Fast Food emporium.
        /// The user selects a burger, side order, drink, and dessert, and the program calculates the total calories based on the user's selection.
        /// </summary>
        /// <param name="burger">The user's choice for the burger.</param>
        /// <param name="drink">The user's choice for the drink.</param>
        /// <param name="side">The user's choice for the side.</param>
        /// <param name="dessert">The user's choice for the dessert.</param>
        /// <returns>The total calorie count for the selected meal.</returns>
        /// <example>
        /// GET localhost:xx/api/J1/Menu/{burger}/{drink}/{side}/{dessert} -> Your total calories: {}
        /// GET localhost:xx/api/J1/Menu/4/4/4/4 -> Your total calories: 0
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public int Menu(int burger, int drink, int side, int dessert)
        {



            int[] burgerCal = { 461, 431, 420, 0 };
            int[] drinkCal = { 130, 160, 118, 0 };
            int[] sideCal = { 100, 57, 70, 0 };
            int[] dessertCal = { 167, 266, 75, 0 };

            int CalCount = burgerCal[burger - 1] + drinkCal[drink - 1] + sideCal[side - 1] + dessertCal[dessert - 1];
            return CalCount;
        }

    }

}