using ProjectManagementAPI.Models;
using System.Text.Json.Serialization;

public class TaskItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending";
    public string Assignee { get; set; } = string.Empty;
    public DateTime DueDate { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Guid ProjectId { get; set; }   // <-- Foreign key

    [JsonIgnore]                       // <-- Ignore during POST
    public Project? Project { get; set; }  // <-- Make nullable
}
