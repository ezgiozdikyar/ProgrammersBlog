using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Dtos
{
    public class CategoryAddDto
    {
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(70,ErrorMessage ="{0} {1} karakterden büyük olamaz.")]
        [MinLength(3,ErrorMessage ="{0} {1} karakterden az olamaz.")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        public bool IsActive { get; set; }

    }
}
