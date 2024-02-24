using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2_AishwaryaThakkar.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Calculates and returns the total number of ways to get the sum 10 with two dice.
        /// </summary>
        /// <param name="m">Number of sides on the first die (positive integer).</param>
        /// <param name="n">Number of sides on the second die (positive integer).</param>
        /// <returns>Total number of ways to get the sum 10.</returns>
        /// <example>
        /// GET: /api/J2/DiceGame/{m}/{n} -> "There are {count} total ways to get the sum 10."
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            if (m <= 0 || n <= 0)
            {
                return "Invalid input. Please provide positive integers for m and n.";
            }

            int count = 0;
            for (int i = 1; i <= m && i <= 10; i++)
            {
                int j = 10 - i;
                if (j >= 1 && j <= n)
                {
                    count++;
                }
            }

            return $"There are {count} total ways to get the sum 10.";
        }
    }
}