using System.ComponentModel.DataAnnotations;

namespace dotnet_crud.Models
{
    public class Brand
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int EstablishedYear { get; set; }
        public string BrandLogo { get; set; }
    }
}
