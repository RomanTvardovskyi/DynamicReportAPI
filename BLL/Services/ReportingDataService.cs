using BLL.Services.Interfaces;
using DAL;
using DAL.Models;
using System.Reflection;
using BLL.Dtos;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<ReportingDataDto>> GetReportingData()
        {
            var reportingData = await (
                from r in _dynamicReportContext.ReportingData
                join m in _dynamicReportContext.MasterInformation
                    on r.OrganizationId equals m.OrganizationId
            select new ReportingDataDto
            {
                OrganizationId = m.OrganizationId,
                OrganizationName = m.OrganizationName,
                TaxId = m.TaxId,
                PrimaryContact = m.PrimaryContact,
                CreatedOn = m.CreatedOn,
                CreatedBy = m.CreatedBy,
                Id = r.Id,
                Question = r.Question,
                Answer = r.Answer
            }).ToListAsync();

            return reportingData;
        }
    }
}
