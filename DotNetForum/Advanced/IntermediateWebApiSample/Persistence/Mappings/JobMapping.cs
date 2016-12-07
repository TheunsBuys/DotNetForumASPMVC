using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using IntermediateWebApiSample.Domain;

namespace IntermediateWebApiSample.Persistence.Mappings
{
    public class JobMapping : EntityTypeConfiguration<Job>
    {
        public JobMapping()
        {
            HasKey(pk => pk.JobId);

            Property(pk => pk.JobId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Description)
                .IsRequired();

            Property(x => x.Location)
                .IsRequired();
        }
    }
}