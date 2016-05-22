namespace Tungsten
{
    public class Assignment
    {
        public AssignmentType AssignedTo { get; set; }

        public User User { get; set; }

        public User[] Users { get; set; }

        public Team Team { get; set; }

        public Team[] Teams { get; set; }
    }
}