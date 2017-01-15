using System.Data.Entity;
using IntermediateWebApiSample.Domain;
using IntermediateWebApiSample.Persistence.Mappings;

namespace IntermediateWebApiSample.Persistence.Contexts
{
    public class JobsContext : DbContext
    {
        public JobsContext() : base("name=IntermediateWebApiDBConnectionString")
        {
        }

        public virtual DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new JobMapping());
        }
    }
}