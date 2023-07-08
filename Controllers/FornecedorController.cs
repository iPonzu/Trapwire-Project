using Models;
using MyData;

namespace Controllers{
    public class FornecedorController{
        public static void Create(string nome, string nomeSocial, string cnpj, string endereco, string telefone){
            if (nome == null || nomeSocial.Length == 0 || nomeSocial == null || nomeSocial.Length == 0 || cnpj == null || cnpj.Length == null || endereco == null || endereco.Length == 0 || telefone == null || telefone.Length == 0){
                throw new Exception("Fornecedor inválido");
            }
            new FornecedorModels(nome, nomeSocial, cnpj, endereco, telefone);
        }
        
         public static void Update(string idRef, string nome, string nomeSocial, string cnpj, string endereco, string telefone){
            int id = 0;
            try{
                id = int.Parse(idRef);
            } catch (Exception e){
                throw new Exception("ID inválido");
            }
            FornecedorModels fornecedor = FornecedorModels.ReadById(id);
            if (nome == null || nomeSocial == null || cnpj == null || endereco == null || telefone == null){
                throw new Exception("Fornecedor inválida");
            }
            if(nome != null && nome.Length > 0 || nomeSocial != null && nomeSocial.Length > 0 || cnpj != null && cnpj.Length > 0 || endereco != null && endereco.Length > 0 || telefone != null && telefone.Length > 0){
                fornecedor.Nome = nome;
                fornecedor.NomeSocial = nomeSocial;
                fornecedor.Cnpj = cnpj;
                fornecedor.Endereco =  endereco;
                fornecedor.Telefone = telefone;
            }

            FornecedorModels.Update(fornecedor);
        }
        public static void Delete(string idRef, string nome){
            using(var context = new Context()){
                var fornecedor = context.Fornecedores.FirstOrDefault(f => f.Nome == nome);
                if(fornecedor != null){
                    context.Fornecedores.Remove(fornecedor);
                    context.SaveChanges();
                }
            }
        }

        public static List<FornecedorModels> Read(){
            return FornecedorModels.Read();
        }

        public static FornecedorModels ReadById(int id){
            return FornecedorModels.ReadById(id);
        }
    }   
}