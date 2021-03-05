using System.ComponentModel.DataAnnotations;

namespace prod_store_cs.Models {
  public class Product{
    [Key]
    public int Id { get; set;}
    
    [Required(ErrorMessage ="Este campo é obrigatório")]
    [MaxLength(60, ErrorMessage="Este campo deve ter até 60 caracters")]
    [MinLength(3, ErrorMessage="Este campo deve ter mais de 3 caracteres")]
    public string Title {get;set;}

    [MaxLength(1024,ErrorMessage="Máximo de 1024 caracteres")]
    public string Description {get;set;}

    [Required(ErrorMessage="Informe o preço")]
    [Range(1,int.MaxValue,ErrorMessage="O preço tem que ser maior que 0")]
    public decimal Price {get;set;}

    [Required(ErrorMessage="Informe a categoria")]
    [Range(1,int.MaxValue,ErrorMessage="Categoria inválida")]
    public int CategoryId { get; set;}
    public Category Category {get ; set;}
    
  }
}