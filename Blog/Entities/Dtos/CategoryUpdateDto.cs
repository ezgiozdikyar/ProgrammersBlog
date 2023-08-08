using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string Description { get; set; }

        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        public bool IsActive { get; set; }

        [DisplayName("Silindi mi?")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        public bool IsDeleted { get; set; }
    }
}
