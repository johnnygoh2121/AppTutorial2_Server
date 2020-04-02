using AppTotutrial2.Model;
using AppTutorial2_Server.Class;
using AppTutorial2_Server.SQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppTutorial2_Server.Controllers
{
    [ApiController]
   // [Route("[controller]")]

    [Route("mobws/cs")]
    public class DeliveryOrderController : ControllerBase
    {
        readonly IConfiguration _configuration;
        readonly string _dbName = "DatabaseConn";
        string _dbConnectionStr = "";

        public DeliveryOrderController(IConfiguration configuration)
        {
            _configuration = configuration;
            _dbConnectionStr = _configuration.GetConnectionString(_dbName);
        }

        [HttpPost]
        public ODLN[] GetDOs(Cio cio)
        {
            Cio newCio = cio; // the pass in extract info

            SQL_ODLN helper = new SQL_ODLN(_dbConnectionStr);
            return helper.GetDeliveryOrder();
        }

    }
}