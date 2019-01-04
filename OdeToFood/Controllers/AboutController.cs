using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public String Phone()
        {
            return "+555 55 555555555";
        }

        public String Address()
        {
            return "USA";
        }
    }
}
