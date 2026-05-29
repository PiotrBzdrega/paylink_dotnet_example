using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorEmpty.Models;

public class MessageDetails
{
    public DateTime Timestamp { get; set; }
    [Required]
    [StringLength(15)]
    
    public required string Message { get; set; }

    [Required(ErrorMessage ="Level is required")]
    public string? LevelId { get; set; }
}
