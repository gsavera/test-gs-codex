using GS.PrototipoCodex.DTOs;
using GS.PrototipoCodex.Models;
using GS.PrototipoCodex.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GS.PrototipoCodex.Controllers
{
    /// <summary>
    /// Controller responsible for task management.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _repository;

        /// <summary>
        /// Initializes a new instance of <see cref="TasksController"/>.
        /// </summary>
        public TasksController(ITaskRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Retrieves all tasks.
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<TaskDto>> GetAll()
        {
            var result = _repository.GetAll().Select(MapToDto);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves a specific task by identifier.
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<TaskDto> Get(Guid id)
        {
            var task = _repository.Get(id);
            if (task == null)
                return NotFound();
            return Ok(MapToDto(task));
        }

        /// <summary>
        /// Creates a new task.
        /// </summary>
        [HttpPost]
        public ActionResult<TaskDto> Create(CreateTaskDto dto)
        {
            var item = new TaskItem { Title = dto.Title, Description = dto.Description };
            var created = _repository.Add(item);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, MapToDto(created));
        }

        /// <summary>
        /// Marks an existing task as completed.
        /// </summary>
        [HttpPut("{id}/complete")]
        public IActionResult Complete(Guid id)
        {
            if (!_repository.Complete(id))
                return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Deletes a task.
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (!_repository.Delete(id))
                return NotFound();
            return NoContent();
        }

        private static TaskDto MapToDto(TaskItem item) => new()
        {
            Id = item.Id,
            Title = item.Title,
            Description = item.Description,
            Status = item.Status,
            CreatedAt = item.CreatedAt
        };
    }
}
