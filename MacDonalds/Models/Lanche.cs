using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacDonalds.Models
{
    public class Lanche
    {
        public int LancheId { get; set; } // com "Id" o EF identifica que é a PrimaryKey

        // Data Annotations (definir regras de cada propriedade - tamnho, obrigatorio, etc)
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo 10 e no máximo 80 carateres")]
        [Required(ErrorMessage = "Informe o nome do lanche")]
        [Display(Name = "Nome do lanche")]
        public string Nome { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "A {0} deve ter no mínimo 20 e no máximo 200 carateres")]
        [Required(ErrorMessage = "Informe a descrição do lanche")]
        [Display(Name = "Descrição do lanche")]
        public string DescricaoCurta { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "A {0} deve ter no mínimo 20 e no máximo 200 carateres")]
        [Required(ErrorMessage = "Informe a descrição detalhada do lanche")]
        [Display(Name = "Descrição detalhada do lanche")]
        public string DescricaoDetalhada { get; set; }
                
        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
                
        [Display(Name = "Caminho imagem normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo 200 carateres")]        
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo 200 carateres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Stock")]
        public bool EmStock { get; set; }

        // definir o relacionamento entre Lanche e Categoria (Propriedades de navegação)
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
