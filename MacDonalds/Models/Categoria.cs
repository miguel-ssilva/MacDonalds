using System.ComponentModel.DataAnnotations;

namespace MacDonalds.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; } // com "Id" o EF identifica que é a PrimaryKey

        [StringLength(100, ErrorMessage ="O tamanho máximo é 100 carateres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 carateres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        // definir que vamos ter a relação de 1 para Muitos
        // Criamos uma proipriedade do tipo List
        public List<Lanche> Lanches { get; set; }
    }
}
