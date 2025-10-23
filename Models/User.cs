using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectManagementAPI.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;

        
        public string Role { get; set; } = "User";  // Default role

        public string? Department { get; set; }     // Optional
    }
}
