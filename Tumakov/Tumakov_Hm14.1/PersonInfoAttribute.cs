

namespace Tumakov
{
    [AttributeUsage(AttributeTargets.Class)]
    class PersonInfoAttribute : Attribute
    {
        public string Name {  get; }
        public string OrganizationName { get; }

        public PersonInfoAttribute(string name, string organizationName)
        {
            Name = name;
            OrganizationName = organizationName;
        }
    }
}
