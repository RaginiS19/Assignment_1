using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        [HttpGet("q1/Welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }

        [HttpGet("q2/Greeting")]
        public string Greeting(string name)
        {
            return $"Hello {name}!";
        }

        [HttpGet("q3/Cube/{number}")]
        public int Cube(int number)
        {
            return number * number * number;
        }

        [HttpPost("q4/knockknock")]
        public string KnockKnock()
        {
            return "Who's there?";
        }

        [HttpPost("q5/secret")]
        public string secret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }

        [HttpGet("q6/hexagon")]
        public double Hexagon([FromQuery] double side)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
        }

        [HttpGet("q7/timemachine")]
        public string TimeMachine([FromQuery] int days)
        {
            DateTime currentDate = DateTime.Today;

            DateTime newDate = currentDate.AddDays(days);

            return currentDate.ToString("yyyy-MM-dd");
        }

        [HttpPost("q8/squashfellows")]
        public String squashFellows([FromForm] int small, [FromForm] int large)
        {
            Double smallPlushiesTotal = small * 25.50;
            Double largePlushiesTotal = large * 40.50;
            Double subTotal = smallPlushiesTotal + largePlushiesTotal;
            Double tax = 0.13;
            Double totalTax = subTotal * tax;
            Double total = subTotal + totalTax;

            return $"{small} Small @ $25.50 = ${smallPlushiesTotal:C}; {large} Large @ $40.50 = ${largePlushiesTotal:C}; Subtotal = {subTotal:C}; Tax = {totalTax:C} HST; Total = {total:C}";
        }

    }
}
