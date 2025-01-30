using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DBFirstProje.Web.Models
{
    public class Product
    {
        [Key]//primary key olacak
       
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} alanı boş bırakılamaz."),DisplayName("Ürün Adı")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz."),DisplayName("Fiyatı")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz."),DisplayName("Stok Miktarı")]
        public int Stock { get; set; }
  
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz."), DisplayName("Ürün Resmi")]
        public string? ImageUrl { get; set; }

        //sonradan eklendiler

        [DisplayName("Ürün Rengi"),StringLength(50), AllowNull]
        public string? Color { get; set; }

        [DisplayName("Ürün Genişlik"),AllowNull]
        public int? Width { get; set; }

        [DisplayName("Ürün Yükseklik"),AllowNull]
        public int? Height { get; set; }

        [DisplayName("Ürün Açıklama"),StringLength(200), AllowNull]
        public string? Description { get; set; }
    }
}

