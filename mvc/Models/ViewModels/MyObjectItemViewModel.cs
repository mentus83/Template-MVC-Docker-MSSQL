using System.ComponentModel.DataAnnotations;

namespace mvc.Models.ViewModels
{
    public class MyObjectItemViewModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}