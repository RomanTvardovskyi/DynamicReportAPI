namespace BLL.Dtos
{
    public class ReportingDataDto
    {
        public Guid OrganizationId { get; set; }
        
        public string OrganizationName { get; set; }
        
        public Guid TaxId { get; set; }
        
        public string PrimaryContact { get; set; }
        
        public DateTime CreatedOn { get; set; }
        
        public string CreatedBy { get; set; }
        
        public Guid Id { get; set; }
        
        public string Question { get; set; }
        
        public string Answer { get; set; }
    }
}
