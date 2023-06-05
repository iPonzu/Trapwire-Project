using Models;
using MyData;

<<<<<<< HEAD
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
=======
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
>>>>>>> c3b9309cf20c929fcf62d71aa5196aaa3e7de543
    }
}