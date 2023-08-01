namespace DesignPatterns.BuilderPattern.Method2
{
    public interface IEmployeeBuilderM2
    {
        EmployeeM2 Build();
        void SetEmailAddress(string email);
        void SetFullname(string fullname);
        void SetUsername(string username);
    }
}