using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MacDonalds.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmStock, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(1,'Pão, ovo, presunto, queijo e batata palha','Delicioso pão de hamburguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1,'https://macoratti.net/Imagens/lanches/cheesesalada1.jpg','https://macoratti.net/Imagens/lanches/cheesesalada1.jpg',0,'Cheese Salada',12.50)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
