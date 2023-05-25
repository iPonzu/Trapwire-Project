using Models;
using MyData;

namespace Controllers{
    public class CategoriaController{
        public void Create(string nome){
            if (nome == null || nome.Length == 0) {
                throw new Exception("Nome inválido.");
            }
            new CategoriaModels(nome);
        }

        public static List<CategoriaModels> Read(){
            return CategoriaModels.Read();
        }

        public static CategoriaModels ReadById(int id){
            return CategoriaModels.ReadById(id);
        }
    }
}        