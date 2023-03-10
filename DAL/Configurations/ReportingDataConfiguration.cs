using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class ReportingDataConfiguration : IEntityTypeConfiguration<ReportingData>
    {
        public void Configure(EntityTypeBuilder<ReportingData> builder)
        {
            builder.HasData
                (
                    new ReportingData
                    {
                        Id = Guid.Parse("655b6f4f-3a86-41bf-a45a-2160ab4e2a35"),
                        OrganizationId = Guid.Parse("824e3249-afb0-475b-845e-519a0003b925"),
                        Question = "Agency Name",
                        Answer = "Assured Partners of CA Insurance Services, LLC dba: Wateridge Insurance Services"
                    },
                    new ReportingData
                    {
                        Id = Guid.Parse("fb9f1b9b-9b77-4166-9654-f99cdac4672f"),
                        OrganizationId = Guid.Parse("8956e747-e94c-4acb-ae12-0528061663d6"),
                        Question = "Insurance Carrier(s)",
                        Answer = "Westchester Surplus Lines Ins Co"
                    },
                    new ReportingData
                    {
                        Id = Guid.Parse("75fde238-8ea8-41f1-b773-27404c6ae417"),
                        OrganizationId = Guid.Parse("8956e747-e94c-4acb-ae12-0528061663d6"),
                        Question = "Agency Name",
                        Answer = "Wateridge Insurance Services"
                    },
                    new ReportingData
                    {
                        Id = Guid.Parse("bd94fdac-0871-4d5d-8e53-979cb43f7087"),
                        OrganizationId = Guid.Parse("0e75d353-fb97-4da8-982d-eb5818558f0b"),
                        Question = "Insurance Carrier(s)",
                        Answer = "Middlesex Ins Company"
                    },
                    new ReportingData
                    {
                        Id = Guid.Parse("f5c73b1b-cefe-4c9a-a9cc-3da27695115d"),
                        OrganizationId = Guid.Parse("824e3249-afb0-475b-845e-519a0003b925"),
                        Question = "Fax Number",
                        Answer = "(858)200-9999"
                    }
                );
        }
    }
}
