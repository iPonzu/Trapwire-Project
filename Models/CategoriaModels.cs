using System.ComponentModel.DataAnnotations.Schema;
using System;
using MyData;

namespace Models{
    public class CategoriaModels{
        [Column("ID Categoria")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Nome: ")]
        public string Nome { get; set; }

        public CategoriaModels(string nome){
            this.Nome = nome;

            this.Create(this);
        }

        public CategoriaModels() {}

        public void Create(CategoriaModels categoria){
            using(var context = new Context()){
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }
        }

        public static List<CategoriaModels> Read(){
            using(var context = new Context()){
                return context.Categorias.ToList();
            }
        }

        public static CategoriaModels ReadById(int id){
            using(var context = new Context()){
                var categoria = context.Categorias.Find(id);
                return categoria;
            }      
        }
    }
}    