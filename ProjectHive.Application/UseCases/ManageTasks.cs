namespace ProjectHive.Application.UseCases
{
    public class ManageTasks
    {
        private readonly ITaskRepository _taskRepository;

        public ManageTasks(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void CreateTask(Task task)
        {
            _taskRepository.Save(task);
        }

        public Task ViewTask(int id)
        {
            return _taskRepository.FindById(id);
        }

        public IEnumerable<Task> ViewAllTasks()
        {
            return _taskRepository.FindAll();
        }

        public void RemoveTask(int id)
        {
            _taskRepository.Delete(id);
        }
    }
}
