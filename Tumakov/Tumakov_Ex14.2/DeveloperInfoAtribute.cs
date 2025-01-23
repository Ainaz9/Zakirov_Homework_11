
namespace Tumakov
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; }
        public DateTime DateOfDevelopment { get; }

        public DeveloperInfoAttribute(string developerName, string dateOfDevelopment)
        {
            DeveloperName = developerName;
            DateOfDevelopment = DateTime.Parse(dateOfDevelopment);
        }
    }
}
