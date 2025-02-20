namespace ProjectHive.Infrastructure.Persistence.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DbContext _context;

        public TaskRepository(DbContext context)
        {
            _context = context;
        }

        public void Save(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public Task FindById(int id)
        {
            return _context.Tasks.Find(id);
        }

        public IEnumerable<Task> FindAll()
        {
            return _context.Tasks.ToList();
        }

        public void Delete(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }
    }
}
