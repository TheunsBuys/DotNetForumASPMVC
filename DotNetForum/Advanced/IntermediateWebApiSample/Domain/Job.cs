namespace IntermediateWebApiSample.Domain
{
    public class Job
    {
        private Job() 
        {
            //a parameterless constructor is required for entity framework
            //we make it private in this case to enforce construction injection of Job's dependencies.
        }

        public Job(string description, string location)
        {
            Description = description;
            Location = location;
        }

        public int JobId { get; private set; } //This is our primary key as annotated in the EntityFramework code first fluent mappings.
        public string Description { get; private set; } 
        public string Location { get; private set; }

        public void UpdateLocation(string location)
        {
            //do the business logic of updating locations
            Location = location;
        }

        public void UpdateDescription(string description)
        {
            //do the business logic of updating description
            Description = description;
        }
    }
}