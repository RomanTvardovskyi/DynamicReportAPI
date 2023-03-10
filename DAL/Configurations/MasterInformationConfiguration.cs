using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class MasterInformationConfiguration : IEntityTypeConfiguration<MasterInformation>
    {
        public void Configure(EntityTypeBuilder<MasterInformation> builder)
        {
            builder.HasData
                (
                    new MasterInformation
                    {
                        OrganizationId = Guid.Parse("824e3249-afb0-475b-845e-519a0003b925"),
                        OrganizationName = "Org 1",
                        TaxId = Guid.NewGuid(),
                        PrimaryContact = "john@ahaapps.com",
                        CreatedOn = DateTime.Parse("2/3/2023"),
                        CreatedBy = "John"
                    },
                    new MasterInformation
                    {
                        OrganizationId = Guid.Parse("8956e747-e94c-4acb-ae12-0528061663d6"),
                        OrganizationName = "Org 2",
                        TaxId = Guid.NewGuid(),
                        PrimaryContact = "catherine@ahaapps.com",
                        CreatedOn = DateTime.Parse("1/1/2023"),
                        CreatedBy = "Jerry"
                    },
                    new MasterInformation
                    {
                        OrganizationId = Guid.Parse("0e75d353-fb97-4da8-982d-eb5818558f0b"),
                        OrganizationName = "Org 3",
                        TaxId = Guid.NewGuid(),
                        PrimaryContact = "frances@ahaapps.com",
                        CreatedOn = DateTime.Parse("1/1/2023"),
                        CreatedBy = "Rick"
                    }
                );
        }
    }
}
