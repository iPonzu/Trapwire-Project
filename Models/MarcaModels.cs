using System.ComponentModel.DataAnnotations.Schema;
using MyData;

namespace Models{
    public class MarcaModels{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID Marca")]
        public int Id { get; set; }

        [Column("Nome da marca: ")]
        public string Nome { get; set; }

        public MarcaModels(string nome) {
            this.Nome = nome;


            this.Create(this);
        }


        public MarcaModels(){}

        public void Create(MarcaModels marca){
            using (var context = new Context()){
                context.Marcas.Add(marca);
                context.SaveChanges();
            }
        }

        public static MarcaModels Update(MarcaModels marca){
            using (var context = new Context()){
                context.Marcas.Update(marca);
                context.SaveChanges();


                return marca;
            }
        }        
        public static List<MarcaModels> Read(){
            using (var context = new Context()){
                return context.Marcas.ToList();
            }
        }
        public static MarcaModels ReadById(int id){
            using (var context = new Context()){
                var marca = context.Marcas.Find(id);
                return marca;
            }  
        }
    }
}