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
            // int id = 0;
            // try{
            //     int.Parse(idRef);
            // } catch (Exception e){
            //     throw new Exception("ID inválido.");
            // }
            // ProdutoModels produto = ProdutoModels.ReadById(id);
            // if(produto == null){
            //     throw new Exception("Produto inválido.");
            // }
            // if(modeloid != null && modeloid.Length > 0 || categoriaid != null && categoriaid.Length > 0){
            //     produto.Modeloid = modeloid;
            //     produto.Categoriaid = categoriaid;  
            // }

            // ProdutoModels.Update(produto);
            using (var context = new Context()){
                var produto = context.Produtos.FirstOrDefault(p => p.Modeloid == modeloid && p.Categoriaid == categoriaid);
                if(produto != null){
                    produto.Modeloid = modeloid;
                    produto.Categoriaid = categoriaid;
                    context.Produtos.Update(produto);
                    context.SaveChanges();
                }
            }
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
