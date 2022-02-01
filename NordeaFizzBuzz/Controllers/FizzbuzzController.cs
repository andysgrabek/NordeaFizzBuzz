using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace NordeaFizzBuzz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzbuzzController : ControllerBase
    {
        private const int StartFizz = 1;
        private const int EndFizz = 100;
        private const int FizzDivisor = 3;
        private const string FizzText = "Nordea";
        private const int BuzzDivisor = 5;
        private const string BuzzText = "Bank";
        private const int FizzBuzzDivisor = FizzDivisor * BuzzDivisor;
        private const string FizzBuzzText = FizzText + " " + BuzzText;

        private static string CreateFizzBuzzText(int x)
        {
            if (x % FizzBuzzDivisor == 0)
            {
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

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Enumerable.Range(StartFizz, EndFizz)
                .Select(CreateFizzBuzzText)
                .ToArray();
        }
        
    }
}
