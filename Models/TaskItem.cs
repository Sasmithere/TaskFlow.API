// For controllers
using Microsoft.AspNetCore.Mvc;

// For DbContext
using Microsoft.EntityFrameworkCore;

namespace TaskFlow.API.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, InProgress, Completed
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsComplete { get; set; }
    }
}

// This code defines a TaskItem model for a task management application.