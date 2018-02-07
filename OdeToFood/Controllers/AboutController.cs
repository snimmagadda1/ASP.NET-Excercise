using System;
using Microsoft.AspNetCore.Mvc;
namespace OdeToFood.Controllers
{
    // MVC framework knows to look for name of controller in URL
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "1+555+555+5555";
        }

        // MVC framework knows to look for name of action in url
        public string Address()
        {
            return "USA";
        }
    }
}
