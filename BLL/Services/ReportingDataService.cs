using BLL.Services.Interfaces;
using DAL;
using DAL.Models;
using System.Reflection;

namespace BLL.Services
{
    public class ReportingDataService : IReportingDataService
    {
        private readonly DynamicReportContext _dynamicReportContext;

        public ReportingDataService(DynamicReportContext dynamicReportContext)
        {
            _dynamicReportContext = dynamicReportContext;
        }

        public IEnumerable<string> GetReportingColumns()
        {
            var reportingData = new ReportingData();
            var columns = reportingData.GetType().GetProperties()
                .Where(p => !p.GetGetMethod().IsVirtual)
                .Select(p => p.Name);

            return columns;
        }
    }
}
