namespace DAL.Models
{
    public class ReportingData
    {
        public Guid Id { get; set; }

        public Guid OrganizationId { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public virtual MasterInformation MasterInformation { get; set; }
    }
}
