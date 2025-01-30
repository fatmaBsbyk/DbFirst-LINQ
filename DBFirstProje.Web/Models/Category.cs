
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DBFirstProje.Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} alanı boş bırakılamaz."),
            DisplayName("Kategori Adı"),
            StringLength(100,ErrorMessage ="{0} alanı maksimum {1} karakter olabilir.")]
        public string? CategoryName { get; set; }
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz."),
            DisplayName("Kategori Açıklaması"),
            StringLength(250, ErrorMessage = "{0} alanı maksimum {1} karakter olabilir.")]
        public string? Description { get; set; }

        [DisplayName("Alt Kategori 1"),
            StringLength(100),
            AllowNull]
        public string? SubCategory1 { get; set; }=string.Empty;

        [DisplayName("Alt Kategori 2"),
            StringLength(100),
            AllowNull]
        public string? SubCategory2 { get; set; }=string.Empty;

        [DisplayName("Alt Kategori 3"),
            StringLength(100),
            AllowNull]
        public string? SubCategory3 { get; set; }=string.Empty;

        [DisplayName("Alt Kategori 4"),
            StringLength(100),
            AllowNull]
        public string? SubCategory4 { get; set; } = string.Empty;
    }
}


