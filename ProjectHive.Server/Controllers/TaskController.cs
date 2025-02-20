namespace ProjectHive.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ManageTasks _manageTasks;

        public TaskController(ManageTasks manageTasks)
        {
            _manageTasks = manageTasks;
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] Task task)
        {
            _manageTasks.CreateTask(task);
            return Ok(new { Message = "Task created successfully" });
        }

        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {
            var task = _manageTasks.ViewTask(id);
            return Ok(task);
        }

        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var tasks = _manageTasks.ViewAllTasks();
            return Ok(tasks);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            _manageTasks.RemoveTask(id);
            return Ok(new { Message = "Task deleted successfully" });
        }
    }
}
