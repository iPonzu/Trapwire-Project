using Models;
using MyData;

namespace Controllers{
    public class EstoqueController{
        public void Create(string nome, string endereco){
            if(nome == null || nome.Length == 0 || endereco == null || endereco.Length == 0){
                throw new Exception("Estoque não encontrado");
            }
        }
        public static void Update(string idRef, string nome, string endereco){
            int id = 0;
            try{
                id = int.Parse(idRef);
            } catch (Exception e){
                throw new Exception("ID inválido.");
            }
            EstoqueModels estoque = EstoqueModels.ReadById(id);
            if(estoque == null){
                throw new Exception("Estoque inválido.");
            }
            if(nome != null && nome.Length > 0 || endereco != null && endereco.Length > 0){
                estoque.Nome = nome;
                estoque.Endereco = endereco;
            }
            EstoqueModels.Update(estoque);
        }
        public static void Delete(string idRef){
            int id = 0;
            try{
                id = int.Parse(idRef);
            } catch (Exception e){
                throw new Exception ("ID Inválido.");
            }
            EstoqueModels estoque = EstoqueModels.ReadById(id);
            if(estoque == null){
                throw new Exception("Estoque inválido.");
            }
            EstoqueModels.Delete(estoque);
        }
        
        public static List<EstoqueModels> Read(){
            return EstoqueModels.Read();
        }
        public static EstoqueModels ReadById(int id){
            return EstoqueModels.ReadById(id);
        }

    }

}