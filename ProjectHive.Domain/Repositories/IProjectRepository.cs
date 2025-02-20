namespace ProjectHive.Domain.Repositories
{
    public interface IProjectRepository
    {
        void Save(Project project);
        Project FindById(int id);
        IEnumerable<Project> FindAll();
        void Delete(int id);
    }
}
