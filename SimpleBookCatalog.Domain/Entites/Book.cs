using SimpleBookCatalog.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SimpleBookCatalog.Domain.Entites
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter title")]
        [StringLength(50)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please enter author")]
        [StringLength(50)]
        public string? Author { get; set; }

        [Required]
        public DateTime? PublicationDate { get; set; }

        [EnumDataType(typeof(Category), ErrorMessage = "Please select a category")]
        public Category Category { get; set; }
    }
}
