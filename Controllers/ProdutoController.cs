using Models;
using MyData;

namespace Controllers{
    public class ProdutoController{
        public static void Create(string modeloid, string categoriaid){
            if (modeloid == null || categoriaid == null){
                throw new Exception("Produto Inválido.");
            }
            new ProdutoModels(modeloid , categoriaid);
        }
        public static void Update(string idRef, string modeloid, string categoriaid){
            int id = 0;
            try{
                int.Parse(idRef);
            } catch (Exception e){
                throw new Exception("ID inválido.");
            }
            ProdutoModels produto = ProdutoModels.ReadById(id);
            if(produto == null){
                throw new Exception("Produto inválido.");
            }
            if(modeloid != null && modeloid.Length > 0 || categoriaid != null && categoriaid.Length > 0){
                produto.Modeloid = modeloid;
                produto.Categoriaid = categoriaid;
                
            }

            ProdutoModels.Update(produto);
        }
        public static void Delete(string idRef){
            int id = 0;
            try{
                id = int.Parse(idRef);
            }catch (Exception e){
                throw new Exception("ID inválido.");
            }
            ProdutoModels produto = ProdutoModels.ReadById(id);
            if(produto == null){
                throw new Exception("Produto inválido");
            }

            ProdutoModels.Delete(produto);
        }
        public static List<ProdutoModels> Read(){
            return ProdutoModels.Read();
        }
        public static ProdutoModels ReadById(int id){
            return ProdutoModels.ReadById(id);
        }

    }
}    
