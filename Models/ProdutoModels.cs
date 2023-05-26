using System.ComponentModel.DataAnnotations.Schema;
using System;
using MyData;

namespace Models{
    public class ProdutoModels{

        [Column("ID Produto")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get;set; }
        [Column("Marca")]
        public string Marca { get; set; }
        [Column("Modelo")]
        public string Modeloid { get; set; }
        [Column("Categoria")]
        public string Categoriaid { get; set; }

        public ProdutoModels(string marca, string modeloid, string categoriaid){
            this.Marca = marca;
            this.Modeloid = modeloid;
            this.Categoriaid = categoriaid;

            this.Create(this);
        }
        public ProdutoModels(){}

        public void Create(ProdutoModels produto){
            using(var context = new Context()){
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        public static List<ProdutoModels> Read(){
            using(var context = new Context()){
                return context.Produtos.ToList();
            }
        }

        public static ProdutoModels ReadById(int id){
            using(var context = new Context()){
                var produto = context.Produtos.Find(id);
                return produto;
            }
        }
    }
}    
