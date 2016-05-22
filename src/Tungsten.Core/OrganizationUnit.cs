namespace Tungsten
{
    public class OrganizationUnit
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public OrganizationUnit Parent { get; set; }

        public OrganizationUnit[] SubUnits { get; set; }
    }
}