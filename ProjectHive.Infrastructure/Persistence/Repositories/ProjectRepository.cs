namespace ProjectHive.Infrastructure.Persistence.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DbContext _context;

        public ProjectRepository(DbContext context)
        {
            _context = context;
        }

        public void Save(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public Project FindById(int id)
        {
            return _context.Projects.Find(id);
        }

        public IEnumerable<Project> FindAll()
        {
            return _context.Projects.ToList();
        }

        public void Delete(int id)
        {
            var project = _context.Projects.Find(id);
            if (project != null)
            {
                _context.Projects.Remove(project);
                _context.SaveChanges();
            }
        }
    }
}
