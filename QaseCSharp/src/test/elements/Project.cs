namespace QaseCSharp.test.elements
{
    public class Project
    {
        public string ProjectName;
        public string ProjectCode;
        public string Description;
        public string AccessType;

        public Project(string projectName, string projectCode, string description, string accessType)
        {
            ProjectName = projectName;
            ProjectCode = projectCode;
            Description = description;
            AccessType = accessType;
        }
    }
}