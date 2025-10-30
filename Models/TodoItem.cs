using System;
using System.ComponentModel.DataAnnotations;

namespace TodoListMVC.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public string? Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
