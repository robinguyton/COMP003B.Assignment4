using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment4.Models
{
    public class ArsenalModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Summary { get; set; }
    }
}