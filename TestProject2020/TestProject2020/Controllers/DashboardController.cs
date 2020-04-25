using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using BAL.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestProject2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
       

        private readonly ILogger<DashboardController> _logger;
        private readonly IDashboardService _dashboardService;

        public DashboardController(ILogger<DashboardController> logger, IDashboardService dashboardService)
        {
            _logger = logger;
            _dashboardService = dashboardService;
        }

        [HttpGet]
        public IEnumerable<DashboardVM> Get()
        {
            return _dashboardService.GetDashboards();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public DashboardVM Get(long id)
        {
           return _dashboardService.GetDashboard(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] DashboardVM value)
        {
            _dashboardService.CreateDasboard(value);
        }

        
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _dashboardService.DeleteDashboard(id);
        }
    }
}
