using Models;
using MyData;

namespace Controllers{
    public class FornecedorController{
        public void Create(string nome, string nomeSocial, string cnpj, string endereco, string telefone){
            if (nome == null || nomeSocial.Length == 0 || nomeSocial == null || nomeSocial.Length == 0 || cnpj == null || cnpj.Length == null || endereco == null || endereco.Length == 0 || telefone == null || telefone.Length == 0){
                throw new Exception("Fornecedor inválido");
            }
            new FornecedorModels(nome, nomeSocial, cnpj, endereco, telefone);
        }

        public static List<FornecedorModels> Read(){
            return FornecedorModels.Read();
        }

        public static FornecedorModels ReadById(int id){
            return FornecedorModels.ReadById(id);
        }
    }   
}