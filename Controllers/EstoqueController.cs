using Models;
using MyData;

namespace Controllers{
    public class EstoqueController{
        public void Create(string nome, string endereco){
            if(nome == null || nome.Length == 0 || endereco == null || endereco.Length == 0){
                throw new Exception("Estoque não encontrado");
            }
        }
        public static List<EstoqueModels> Read(){
            return EstoqueModels.Read();
        }
        public static EstoqueModels ReadById(int id){
            return EstoqueModels.ReadById(id);
        }

    }

}