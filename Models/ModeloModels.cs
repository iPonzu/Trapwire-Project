using System.ComponentModel.DataAnnotations.Schema;
using MyData;

namespace Models{
    public class ModeloModels{
        [Column("ID Modelo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        [Column("Nome: ")]
        public string Modelo { get; set;}

        public ModeloModels(string modelo){
            this.Modelo = modelo;

            this.Create(this);
        }

        public ModeloModels(){}

        public void Create(ModeloModels modelo){
            using (var context = new Context()){
                context.Modelos.Add(modelo);
                context.SaveChanges();
            }
        }

        public static List<ModeloModels> Read(){
            using (var context = new Context()){
                return context.Modelos.ToList();
            }
        }
        public static ModeloModels ReadById(int id){
            using (var context = new Context()){
                var modelo = context.Modelos.Find(id);
                return modelo;
            }   
        }
    } 
}       