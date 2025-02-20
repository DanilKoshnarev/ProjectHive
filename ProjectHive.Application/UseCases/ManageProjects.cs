namespace ProjectHive.Application.UseCases
{
    public class ManageProjects
    {
        private readonly IProjectRepository _projectRepository;

        public ManageProjects(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void CreateProject(Project project)
        {
            _projectRepository.Save(project);
        }

        public Project ViewProject(int id)
        {
            return _projectRepository.FindById(id);
        }

        public IEnumerable<Project> ViewAllProjects()
        {
            return _projectRepository.FindAll();
        }

        public void RemoveProject(int id)
        {
            _projectRepository.Delete(id);
        }
    }
}
