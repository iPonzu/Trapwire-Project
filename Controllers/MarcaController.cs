using Models;
using MyData;

namespace Controllers{
    public class MarcaController{
        public void Create(string nome) {
            if (nome == null || nome.Length == 0){
                throw new Exception("Marca inválida");
            }
            new MarcaModels(nome);
        }

        public void Update(string idRef, string nome){
            int id = 0;
            try{
                id = int.Parse(idRef);
            } catch (Exception e){
                throw new Exception("ID inválido");
            }
            MarcaModels marca = MarcaModels.ReadById(id);
            if (marca == null){
                throw new Exception("Marca inválida");
            }
            if(nome != null && nome.Length > 0){
                marca.Nome = nome;
            }

            MarcaModels.Update(marca);
        }
        public static List<MarcaModels> Read(){
            return MarcaModels.Read();
        }
        public static MarcaModels ReadById(int id){
            return MarcaModels.ReadById(id);
        }
    }
}