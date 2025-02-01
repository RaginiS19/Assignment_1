using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        // <summary>
        // A welcome greeting to the user
        // </summary>
        // <returns>A welcome greeting based on the course code entered</returns>
        // <example>
        // GET http://localhost:xx/api/q1/welcome -> "Welcome to 5125!"
        // </example>


        [HttpGet("q1/Welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }

        /// <summary>
        /// Receives a name and returns a greeting message for that name.
        /// </summary>
        /// <param name="name">The name to receive</param>
        /// <returns>A message greeting the provided name</returns>
        /// <example>
        /// GET: api/q2/greeting?name=Gary -> "Hi Gary!"
        /// </example>
        /// <example>
        /// GET: api/q2/greeting?name=Renée -> "Hi Renée!"
        /// </example>

        [HttpGet("q2/Greeting")]
        public string Greeting(string name)
        {
            return $"Hi {name}!";
        }

        /// <summary>
        /// Receives an integer and outputs the cube of that number
        /// </summary>
        /// <param name="number">The integer to receive</param>
        /// <returns>The cube of the integer</returns>
        /// <example>
        /// GET: api/q3/cube/{number} -> {number} cubed
        /// </example>
        /// <example>
        /// GET: api/q3/cube/4 -> 64
        /// </example>
        /// <example>
        /// GET: api/q3/cube/-4 -> -64
        /// </example>
        /// <example>
        /// GET: api/q3/cube/10 -> 1000
        /// </example>

        [HttpGet("q3/Cube/{number}")]
        public int Cube(int number)
        {
            return number * number * number;
        }

        /// <summary>
        /// Receives a POST request and says knock knock by returning "Who's there?".
        /// </summary>
        /// <returns>A string stating "Who's there?" as it says knock knock .</returns>
        /// <example>
        /// POST: api/q4/knockknock -> "Who's there?"
        /// </example>

        [HttpPost("q4/knockknock")]
        public string KnockKnock()
        {
            return "Who's there?";
        }

    

        /// <summary> 
        ///  Receives a secret integer and outputs an acknowledgement message containing the secret 
        /// </summary>
        /// <param name="secret">The secret integer to receive</param> 
        /// <returns>A message acknowledging the secret</returns> 
        /// <example>
        /// POST: api/q5/secret with BODY: 5 -> "Shh.. the secret is 5"
        /// </example>
        /// <example> 
        /// POST: api/q5/secret with BODY: -200 -> "Shh.. the secret is -200" 
        /// </example>

        [HttpPost("q5/secret")]
        public string secret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }

        /// <summary>
        /// Receives the side length of a regular hexagon and outputs the area of the hexagon using the formula
        /// (3 * √3 / 2) * side²
        /// </summary>
        /// <param name="side">The side length of the hexagon</param>
        /// <returns>The area of the regular hexagon</returns>
        /// <example>
        /// GET: api/q6/hexagon?side=1 -> 2.598076211353316
        /// </example>
        /// <example>
        /// GET: api/q6/hexagon?side=1.5 -> 5.845671475544961
        /// </example>
        /// <example>
        /// GET: api/q6/hexagon?side=20 -> 1039.2304845413264
        /// </example>

        [HttpGet("q6/hexagon")]
        public double Hexagon([FromQuery] double side)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
        }

        /// <summary>
        /// Receives a number of days and returns the current date adjusted by the specified number of days.
        /// </summary>
        /// <param name="days">The number of days to adjust the current date by</param>
        /// <returns>A string representation of the adjusted date in "yyyy-MM-dd" format</returns>
        /// <example>
        /// GET: api/q7/timemachine?days=1 -> "2000-01-02"
        /// GET: api/q7/timemachine?days=-1 -> "1999-12-31"
        /// </example>

        [HttpGet("q7/timemachine")]
        public string TimeMachine([FromQuery] int days)
        {
            DateTime currentDate = DateTime.Today;

            DateTime newDate = currentDate.AddDays(days);

            return newDate.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Receives the number of Small and Large SquashFellows plushies and outputs the checkout summary
        /// including the subtotal, tax, and total price for the order.
        /// </summary>
        /// <param name="small">The number of Small plushies ordered</param>
        /// <param name="large">The number of Large plushies ordered</param>
        /// <returns>A message with the itemized checkout summary including prices, subtotal, tax, and total</returns>
        /// <example>
        /// POST: api/q8/squashfellows -> "1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58"
        /// </example>
        /// <example>
        /// POST: api/q8/squashfellows -> "2 Small @ $25.50 = $51.00; 1 Large @ $40.50 = $40.50; Subtotal = $91.50; Tax = $11.90 HST; Total = $103.40"
        /// </example>
        /// <example>
        /// POST: api/q8/squashfellows -> "100 Small @ $25.50 = $2550.00; 100 Large @ $40.50 = $4050.00; Subtotal = $6600.00; Tax = $858.00 HST; Total = $7458.00"
        /// </example>


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
