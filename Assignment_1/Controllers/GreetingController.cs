using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : Controller
    {
        [HttpGet("q1/welcome")]
        public string GET(string name)
        {

            // SELECT balance FROM accounts WHERE accountNo = accountNumber
            return "Welcome to 5125!";

        }



    }
}
