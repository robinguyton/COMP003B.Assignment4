
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace COMP003B.Assignment4
{
    public class RegisterModel
    {

        [Required]
        [StringLength(300)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Summary { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }



        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [CreditCard]
        public string CreditCard { get; set; }


        [Required]
        [Range(1, 10)]
        public string Tickets { get; set; }

        [Required]
        [MinLength(12)][MaxLength(18)]
        public string AFCNumber { get; set; }







    }
}
