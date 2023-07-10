using Models;
using MyData;

namespace Controllers{
    public class CategoriaController{
        public static void Create(string Nome){
            if (Nome == null || Nome.Length == 0) {
                throw new Exception("Nome inválido.");
            }
            new CategoriaModels(Nome);
        }

        public static void Update(string idRef, string Nome){
            // int id = 0;
            // try {
            //     id = int.Parse(idRef);
            // } catch (Exception e) {
            //     throw new Exception("Id inválido");
            // }
            // CategoriaModels categoria = CategoriaModels.ReadById(id);
            // if (categoria == null) {
            //     throw new Exception("Categoria inválido.");
            // }

            // if (Nome != null && Nome.Length > 0) {
            //     categoria.Nome = Nome;
            // }

            // CategoriaModels.Update(categoria);
            using (var context = new Context()){
                var categoria = context.Categorias.FirstOrDefault(c => c.Nome == Nome);
                if(categoria != null){
                    categoria.Nome = Nome;
                    context.Categorias.Update(categoria);
                    context.SaveChanges();
                }
            }
        }
        
        public static void Delete(string nome){
            // int id = 0;
            // try{
            //     id = int.Parse(idRef);
            // } catch (Exception e) {
            //     throw new Exception("ID inválido");
            // }
            // CategoriaModels categoria = CategoriaModels.ReadById(id);
            // if(categoria != null){
            //     throw new Exception("Categoria inválida");
            // }
            
            // CategoriaModels.Delete(categoria);
            using (var context = new Context()){
                var categoria = context.Categorias.FirstOrDefault(c => c.Nome == nome);
                if(categoria != null){
                    context.Categorias.Remove(categoria);
                    context.SaveChanges();
                }
            }
        }

        public static List<CategoriaModels> Read(){
            return CategoriaModels.Read();
        }

        public static CategoriaModels ReadById(int id){
            return CategoriaModels.ReadById(id);
        }
    }
}        