using Models;
using MyData;

namespace Controllers{
    public class ModeloController{
        public void Create(string nome){
            if (nome == null || nome.Length == 0) {
                throw new Exception("Nome inválido.");
            }
            new CategoriaModels(nome);
        }

        public static List<ModeloModels> Read(){
            return ModeloModels.Read();
        }

        public static ModeloModels ReadById(int id){
            return ModeloModels.ReadById(id);
        }
    }
}        