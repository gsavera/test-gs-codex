using GS.PrototipoCodex.Models;
using TaskStatus = GS.PrototipoCodex.Models.TaskStatus;

namespace GS.PrototipoCodex.Repositories
{
    /// <summary>
    /// In-memory implementation of <see cref="ITaskRepository"/> using a static dictionary.
    /// </summary>
    public class InMemoryTaskRepository : ITaskRepository
    {
        private static readonly Dictionary<Guid, TaskItem> _tasks = new();

        /// <inheritdoc />
        public IEnumerable<TaskItem> GetAll() => _tasks.Values;

        /// <inheritdoc />
        public TaskItem? Get(Guid id)
        {
            _tasks.TryGetValue(id, out var item);
            return item;
        }

        /// <inheritdoc />
        public TaskItem Add(TaskItem item)
        {
            item.Id = Guid.NewGuid();
            item.CreatedAt = DateTime.UtcNow;
            _tasks[item.Id] = item;
            return item;
        }

        /// <inheritdoc />
        public bool Complete(Guid id)
        {
            if (_tasks.TryGetValue(id, out var item))
            {
                item.Status = TaskStatus.Completed;
                return true;
            }
            return false;
        }

        /// <inheritdoc />
        public bool Delete(Guid id) => _tasks.Remove(id);
    }
}
