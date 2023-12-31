using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bulkyBook.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set;  }
    [DisplayName("Display Order")]
    [Range(1,100,ErrorMessage = "Must be between 1 - 100 only!!!")]
    public int DiplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

} 