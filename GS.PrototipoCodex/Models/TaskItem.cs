using System;

namespace GS.PrototipoCodex.Models
{
    /// <summary>
    /// Represents a task within the system.
    /// </summary>
    public class TaskItem
    {
        /// <summary>
        /// Identifier of the task.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Title of the task.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Optional description for the task.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Current status of the task.
        /// </summary>
        public TaskStatus Status { get; set; } = TaskStatus.Pending;

        /// <summary>
        /// Date and time when the task was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
