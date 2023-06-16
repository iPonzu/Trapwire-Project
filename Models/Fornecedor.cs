using System.ComponentModel.DataAnnotations.Schema;
using MyData;

namespace Models{
    public class FornecedorModels{
        [Column("ID Fornecedor")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Nome: ")]
        public string Nome { get; set; }
        [Column("Nome Social: ")]
        public string NomeSocial { get; set; }
        [Column("CNPJ: ")]
        public string Cnpj { get; set; }
        [Column("Endereço: ")]
        public string Endereco { get; set; }
        [Column("Telefone: ")]
        public string Telefone { get; set; }
    
        public FornecedorModels(string nome, string nomeSocial, string cnpj, string endereco, string telefone){
            this.Nome = nome;
            this.NomeSocial = nomeSocial;
            this.Cnpj = cnpj;
            this.Endereco = endereco;
            this.Telefone = telefone;

            this.Create(this);

        }
        public FornecedorModels(){}

        public void Create(FornecedorModels fornecedor){
            using (var context = new Context()){
                context.Fornecedores.Add(fornecedor);
                context.SaveChanges();
            }
        }
        public static FornecedorModels Update(FornecedorModels fornecedor){ 
            using(var context = new Context()) {
                context.Fornecedores.Update(fornecedor);
                context.SaveChanges();

                return fornecedor;
            }
        }    
        public static List<FornecedorModels> Read(){
            using (var context = new Context()){
                return context.Fornecedores.ToList();
            }
        }
        public static FornecedorModels ReadById(int id){
            using (var context = new Context()){
                var fornecedor = context.Fornecedores.Find(id);
                return fornecedor;
            }
        }
        
    }
}