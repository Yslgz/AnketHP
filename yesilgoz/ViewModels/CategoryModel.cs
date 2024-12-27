using System.ComponentModel.DataAnnotations;

namespace Anket.ViewModels
{
    public class CategoryModel : BaseModel
    {
     


        [Display(Name = "Adı")]
        [Required(ErrorMessage = "Kategori Adı Giriniz!")]
        public string Name { get; set; }

       

    }
}
