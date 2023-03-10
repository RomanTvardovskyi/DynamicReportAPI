using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DynamicReportAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ReportingDataController : ControllerBase
    {
        private readonly IReportingDataService _reportingDataService;

        public ReportingDataController(IReportingDataService reportingDataService)
        {
            _reportingDataService = reportingDataService;
        }

        [HttpGet("GetReportingColumns")]
        public IActionResult GetReportingColumns()
        {
            var columns = _reportingDataService.GetReportingColumns();

            return Ok(columns);
        }

        [HttpGet("GetReportingData")]
        public async Task<IActionResult> GetReportingData()
        {
            var reportingData = await _reportingDataService.GetReportingData();

            return Ok(reportingData);
        }
        
    }
}
