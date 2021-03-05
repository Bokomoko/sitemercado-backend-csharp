using System.ComponentModel.DataAnnotations;

namespace prod_store_cs.Models 
{
    public class Category{

      [Key]
      public int  Id {get ; set;}

      [Required(ErrorMessage= "Esse campo é obrigatpru")]
      [MaxLength(60, ErrorMessage = "Este campo deve conter até 60 caracters")]
      [MinLength(3, ErrorMessage = "Esse campo deve ter mais de 3 caracteres")]
      public string Title {get ; set;}
    }
}