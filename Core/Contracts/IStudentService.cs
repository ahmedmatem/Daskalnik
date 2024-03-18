namespace Core.Contracts
{
    public interface IStudentService
    {
        Task<int> GetStudentsCountAsync();
    }
}
