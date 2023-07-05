using System.ComponentModel.DataAnnotations.Schema;
using MyData;

namespace Models{
    public class LogisticaModels{
        [Column("ID Logistica")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Data")]
        public string Data { get; set; }
        [Column("Quantidade")]
        public int Quantidade { get; set; }
        public string Produtoid { get; set; }
        public string Estoqueid { get; set; }

        public LogisticaModels(string data, int quantidade, string produtoid, string estoqueid){
            this.Data = data;
            this.Quantidade = quantidade;
            this.Produtoid = produtoid;
            this.Estoqueid = estoqueid;

            this.Create(this);
        }
        public LogisticaModels(){}

        public void Create(LogisticaModels logistica){
            using (var context = new Context()){
                context.Logisticas.Add(logistica);
                context.SaveChanges();
            }
        }

        public static LogisticaModels Update(LogisticaModels logistica){
            using (var context = new Context()){
                context.Logisticas.Update(logistica);
                context.SaveChanges();
                return logistica;
            }
        }
        public static LogisticaModels Delete(LogisticaModels logistica){
            using(var context = new Context()){
                context.Logisticas.Remove(logistica);
                context.SaveChanges();
                return logistica;
            }
        }

        public static List<LogisticaModels> Read(){
            using (var context = new Context()){
                return context.Logisticas.ToList();
            }
        }
        public static LogisticaModels ReadById(int id){
            using (var context = new Context()){
                var logistica = context.Logisticas.Find(id);
                return logistica;
            }
        }
        
    }
}    