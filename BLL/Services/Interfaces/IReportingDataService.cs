using BLL.Dtos;

namespace BLL.Services.Interfaces
{
    public interface IReportingDataService
    {
        IEnumerable<string> GetReportingColumns();

        List<ReportingDataDto> GetReportingData();
    }
}
