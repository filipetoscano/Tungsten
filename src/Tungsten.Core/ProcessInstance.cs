namespace Tungsten
{
    public class ProcessInstance
    {
        public long Id { get; set; }

        public Process Process { get; set; }

        public decimal? PercentComplete { get; set; }

        public HumanTask[] HumanTasks { get; set; }

        public Relation[] Relations { get; set; }
    }
}