using Models;
using MyData;

namespace Controllers{
    public class ModeloController{
        public static void Create(string nome){
            if (nome == null || nome.Length == 0) {
                throw new Exception("Modelo inválido.");
            }
            new ModeloModels(nome);
        }

        public static void Update(string nome){
            // int id = 0;
            // try{
            //     id = int.Parse(idRef);
            // } catch(Exception e){
            //     throw new Exception ("ID Inválido");
            // }
            // ModeloModels modelo = ModeloModels.ReadById(id);
            // if(modelo == null){
            //     throw new Exception("Modelo inválido.");
            // }
            // if(modelo != null){
            //     modelo.Nome = nome;
            // }
            // ModeloModels.Update(modelo);
            using (var context = new Context()){
                var modelo = context.Modelos.FirstOrDefault(m => m.Nome == nome);
                if(modelo != null){
                    modelo.Nome = nome;
                    context.Modelos.Update(modelo);
                    context.SaveChanges();
                }
            }
        }  

        public static void Delete(string idRef, string nome){
            using (var context = new Context()){
                var modelo = context.Modelos.FirstOrDefault(m => m.Nome == nome);
                if(modelo != null){
                    context.Modelos.Remove(modelo);
                    context.SaveChanges();
                }
            }
        } 

        public static List<ModeloModels> Read(){
            return ModeloModels.Read();
        }

        public static ModeloModels ReadById(int id){
            return ModeloModels.ReadById(id);
        }
    }
}        