using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2_AishwaryaThakkar.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Calculates the length of a Sumac sequence.
        /// Starting with two given numbers, T1 and T2, this method generates a sequence
        /// </summary>
        /// <param name="t1">The input for the first number in the sequence.</param>
        /// <param name="t2">The input for the second number in the sequence.</param>
        /// <returns>The length of the number sequence.</returns>
        /// <example>
        /// GET /api/J3/NumSequence/80/30 -> 3
        /// </example>
        [Route("api/J3/NumSequence/{T1}/{T2}")]
        [HttpGet]
        public int CalculateNumSequenceLength(int t1, int t2)
        {
            int count = 2;

            while (t2 < t1)
            {
                (t1, t2, count) = (t2, t1 - t2, count + 1);
            }

            return count;
        }
    }
}