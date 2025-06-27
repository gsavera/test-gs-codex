using System;
using GS.PrototipoCodex.Models;
using TaskStatus = GS.PrototipoCodex.Models.TaskStatus;

namespace GS.PrototipoCodex.DTOs
{
    /// <summary>
    /// Data returned to clients representing a task.
    /// </summary>
    public class TaskDto
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
        /// Description of the task.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Status of the task.
        /// </summary>
        public TaskStatus Status { get; set; }

        /// <summary>
        /// Creation date of the task.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
