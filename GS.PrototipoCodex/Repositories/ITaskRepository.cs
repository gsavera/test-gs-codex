using GS.PrototipoCodex.Models;

namespace GS.PrototipoCodex.Repositories
{
    /// <summary>
    /// Repository contract for task operations.
    /// </summary>
    public interface ITaskRepository
    {
        /// <summary>
        /// Retrieves all tasks.
        /// </summary>
        IEnumerable<TaskItem> GetAll();

        /// <summary>
        /// Retrieves a task by identifier.
        /// </summary>
        TaskItem? Get(Guid id);

        /// <summary>
        /// Adds a new task.
        /// </summary>
        TaskItem Add(TaskItem item);

        /// <summary>
        /// Marks a task as completed.
        /// </summary>
        bool Complete(Guid id);

        /// <summary>
        /// Deletes a task.
        /// </summary>
        bool Delete(Guid id);
    }
}
