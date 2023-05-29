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

        public void Update(string idRef, string nome){
            int id = 0;
            try {
                id = int.Parse(idRef);
            } catch (Exception e) {
                throw new Exception("Id inválido");
            }
            CategoriaModels categoria = CategoriaModels.ReadById(id);
            if (categoria == null) {
                throw new Exception("Categoria inválido.");
            }

            if (nome != null && nome.Length > 0) {
                categoria.Nome = nome;
            }

            CategoriaModels.Update(categoria);
        }

        public static List<CategoriaModels> Read(){
            return CategoriaModels.Read();
        }

        public static CategoriaModels ReadById(int id){
            return CategoriaModels.ReadById(id);
        }
    }
}        