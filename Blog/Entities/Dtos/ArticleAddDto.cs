using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Dtos
{
    public class ArticleAddDto
    {
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olamaz.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden az olamaz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MinLength(20, ErrorMessage = "{0} alanı {1} karakterden az olamaz.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olamaz.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden az olamaz.")]
        public string Thumbnail { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(150, ErrorMessage = "{0} alanı {1} karakterden büyük olamaz.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden az olamaz.")]
        public string SeoAuthor { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(70, ErrorMessage = "{0} alanı {1} karakterden büyük olamaz.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden az olamaz.")]
        public string SeoDescription { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string SeoTags { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public bool IsActive { get; set; }
    }
}
