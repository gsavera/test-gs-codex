using System.ComponentModel.DataAnnotations;

namespace GS.PrototipoCodex.DTOs
{
    /// <summary>
    /// Data required to create a task.
    /// </summary>
    public class CreateTaskDto
    {
        /// <summary>
        /// Title for the task.
        /// </summary>
        [Required]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Optional description of the task.
        /// </summary>
        public string? Description { get; set; }
    }
}
