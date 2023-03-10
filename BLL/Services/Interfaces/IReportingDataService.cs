using BLL.Dtos;

namespace BLL.Services.Interfaces
{
    public interface IReportingDataService
    {
        IEnumerable<string> GetReportingColumns();

        Task<IList<ReportingDataDto>> GetReportingData();

        Task<string>  GetReportingDataAsCsv();
    }
}
