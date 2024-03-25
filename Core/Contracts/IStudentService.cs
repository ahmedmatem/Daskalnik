namespace Core.Contracts
{
    public interface IStudentService
    {
        Task<int> GetStudentsCountAsync();

        Task<int> GetStudentsCountInSchoolAsync(string schoolId);
    }
}
