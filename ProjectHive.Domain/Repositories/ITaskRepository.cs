namespace ProjectHive.Domain.Repositories
{
    public interface ITaskRepository
    {
        void Save(Task task);
        Task FindById(int id);
        IEnumerable<Task> FindAll();
        void Delete(int id);
    }
}
