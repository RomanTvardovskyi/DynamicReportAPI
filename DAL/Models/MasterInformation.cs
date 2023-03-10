namespace DAL.Models
{
    public class MasterInformation
    {
        public Guid OrganizationId { get; set; }

        public string OrganizationName { get; set; }

        public Guid TaxId { get; set; }

        public string PrimaryContact { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public virtual ICollection<ReportingData> ReportingData { get; set; }
    }
}
