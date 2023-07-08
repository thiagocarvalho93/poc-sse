using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SseNotifications.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("notifications")]
        public async Task ConnectSse()
        {
            Response.Headers.Add("Content-Type", "text/event-stream");
            Response.Headers.Add("Cache-Control", "no-cache");
            Response.Headers.Add("Connection", "keep-alive");
            while (true)
            {
                await Response.WriteAsync($"data: Controller at {DateTime.Now}\r\r");
                await Response.Body.FlushAsync();
                await Task.Delay(1000);
            }
        }
    }
}