using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;


namespace NordeaFizzBuzz.Controllers
{
    
    /// <summary>
    /// API controller for 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FizzbuzzController : ControllerBase
    {
        
        //some could be transformed to parameters to the request method
        private const int StartFizz = 1;
        private const int EndFizz = 100;
        private const int FizzDivisor = 3;
        private const string FizzText = "Nordea";
        private const int BuzzDivisor = 5;
        private const string BuzzText = "Bank";
        private const int FizzBuzzDivisor = FizzDivisor * BuzzDivisor;
        private const string FizzBuzzText = FizzText + " " + BuzzText;

        /// <summary>
        /// Helper method to create the fizzbuzz text depending on the number in question
        /// </summary>
        /// <param name="x">number in question</param>
        /// <returns>"Nordea" if x is divisible by 3, "Bank if by 5" and "Nordea Bank" if by both</returns>
        private static string CreateFizzBuzzText(int x)
        {
            //start with the LCM before checking the individual divisors, so early return is viable
            if (x % FizzBuzzDivisor == 0)
            {
                //string interpolation is more readable than string concatenation, but builder could be utilized for larger expressions
                return $"{x}: {FizzBuzzText}";
            }

            if (x % FizzDivisor == 0)
            {
                return $"{x}: {FizzText}";
            }

            if (x % BuzzDivisor == 0)
            {
                return $"{x}: {BuzzText}";
            }

            return x.ToString();

        }

        
        /// <summary>
        /// Computes the fizzbuzz result for numbers in the 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //create a 1-100 range and transform it to a list of (number, word/empty) tuples joint with ':'
            return Enumerable.Range(StartFizz, EndFizz)
                .Select(CreateFizzBuzzText)
                .ToArray();
        }
        
    }
}
