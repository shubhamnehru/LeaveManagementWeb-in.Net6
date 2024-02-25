namespace LeaveManagement.web.Generics.Interfaces
{
    public interface IGenericRepoistory<T> where T : class
    {
        Task<T> AddAsync(T enitity);

        Task UpdateAsync(T enitity);

        Task DeleteAsync(int id);

        Task<T> GetAsync(int? id);

        Task<bool> HasAsync(int id);

        Task<List<T>> GetAllSync();
    }
}
