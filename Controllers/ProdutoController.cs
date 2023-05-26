using Models;
using MyData;

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
}