using System.ComponentModel.DataAnnotations;

namespace EShopApi.Entities
{
    public class Brand
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
