namespace Tungsten
{
    public class HumanTask
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public ProcessInstance ProcessInstance { get; set; }

        public Assignment AssignedTo { get; set; }

        public User ClaimedBy { get; set; }

        public User ExecutedBy { get; set; }
    }
}