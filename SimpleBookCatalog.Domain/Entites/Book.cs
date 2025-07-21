using SimpleBookCatalog.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SimpleBookCatalog.Domain.Entites
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Title { get; set; }

        [Required]
        [StringLength(50)]
        public string? Author{ get; set; }
        public DateTime? PublicationDate { get; set; }
        public Category Category { get; set; }
    }
}
