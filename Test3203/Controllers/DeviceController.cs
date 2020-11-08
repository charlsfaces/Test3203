using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test3203.ModelLayer;
using Test3203.Services;

namespace Test3203.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : Controller
    {
        private readonly IRegisterDevice _registerDevice;
        
        public DeviceController(IRegisterDevice registerDevice)
        {
            _registerDevice = registerDevice;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post([FromBody] IBaseDevice value)
        {
            if (value is ElectricMeter em)
            {
                if (_registerDevice.Register(em))
                {
                    ViewData["Message"] = "Electric Meter registered";
                }
                else
                {
                    ViewData["Message"] = "Electric Meter duplicated";
                }
            }

            if (value is WaterMeter wm)
            {
                if (_registerDevice.Register(wm))
                {
                    ViewData["Message"] = "Water Meter registered";
                }
                else
                {
                    ViewData["Message"] = "Water Meter duplicated";
                }
            }

            if (value is Gateway gw)
            {
                if (_registerDevice.Register(gw))
                {
                    ViewData["Message"] = "Gateway registered";
                }
                else
                {
                    ViewData["Message"] = "Gateway duplicated";
                }
            }

            return View();
        }                                        
    }
}
