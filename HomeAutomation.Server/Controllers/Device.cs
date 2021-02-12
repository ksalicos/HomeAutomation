using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAutomation.Common.Enums;

namespace HomeAutomation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Device : ControllerBase
    {
        [Route("status")]
        public IActionResult Status()
        {
            return Ok(DeviceStatus.Running);
        }
    }
}
