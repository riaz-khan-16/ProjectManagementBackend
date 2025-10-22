using System;
using System.Collections.Generic;

namespace ProjectManagementAPI.Models
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;           // default value
        public string Description { get; set; } = string.Empty;    // default value
        public string CreatedBy { get; set; } = string.Empty;      // default value
        public List<string> Members { get; set; } = new List<string>();

        // One-to-Many: Project has multiple Tasks
        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
