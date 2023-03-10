using BLL.Dtos;

namespace BLL.Services.Interfaces
{
    public interface IReportingDataService
    {
        IEnumerable<string> GetReportingColumns();

        Task<IEnumerable<ReportingDataDto>> GetReportingData();
    }
}
