using System.ComponentModel.DataAnnotations.Schema;
using MyData;

namespace Models{
    public class EstoqueModels{

        [Column("ID Estoque")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Nome do estoque: ")]
        public string Nome { get; set; }
        [Column("Endereço: ")]
        public string Endereco { get; set; }

        public EstoqueModels(string nome, string endereco){
            this.Nome = nome;
            this.Endereco = endereco;

            this.Create(this);
        }

        public EstoqueModels(){}

        public void Create(EstoqueModels estoque){
            using (var context = new Context()){
                context.Estoques.Add(estoque);
                context.SaveChanges();
            }
        }

        public static List<EstoqueModels> Read(){
            using (var context = new Context()){
                return context.Estoques.ToList();
            }
        }
        public static EstoqueModels ReadById(int id){
            using (var context = new Context()){
                var estoque = context.Estoques.Find(id);
                return estoque;
            }
        }
        public static EstoqueModels Update(EstoqueModels estoque){
            using (var context = new Context()){
                context.Estoques.Update(estoque);
                context.SaveChanges();

                return estoque;
            }

        }
    }
}