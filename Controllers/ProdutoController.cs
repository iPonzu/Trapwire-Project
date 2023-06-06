using Models;
using MyData;

public class ProdutoController{
    public void Create(string marcaid, string modeloid, string categoriaid){
        if (marcaid == null || modeloid == null || categoriaid == null || marcaid.Length == 0 || modeloid.Length == 0 || categoriaid.Length == 0){
            throw new Exception("Produto Inválido.");
        }
        new ProdutoModels(marcaid, modeloid, categoriaid);
    }
    public void Update(string idRef, string marcaid, string modeloid, string categoriaid){
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
        if(marcaid != null && marcaid.Length > 0 || modeloid != null && modeloid.Length > 0 || categoriaid != null && categoriaid.Length > 0){
            produto.Marcaid = marcaid;
            produto.Modeloid = modeloid;
            produto.Categoriaid = categoriaid;
            
        }

        ProdutoModels.Update(produto);
    }
    public static List<ProdutoModels> Read(){
        return ProdutoModels.Read();
    }
    public static ProdutoModels ReadById(int id){
        return ProdutoModels.ReadById(id);
<<<<<<< HEAD
namespace Controllers {
    public class ProdutoController{
        public void Create(string marca, string modeloid, string categoriaid){
            if (marca == null || modeloid == null || categoriaid == null || marca.Length == 0 || modeloid.Length == 0 || categoriaid.Length == 0){
                throw new Exception("Produto Inválido.");
            }
            new ProdutoModels(marca, modeloid, categoriaid);
        }
        public static List<ProdutoModels> Read(){
            return ProdutoModels.Read();
        }
        public static ProdutoModels ReadById(int id){
            return ProdutoModels.ReadById(id);
        }
=======
>>>>>>> 395ddfe4c1e11b0058fabd747f7fb5d2b86c94c7
    }
}
