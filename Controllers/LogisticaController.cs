using Models;
using MyData;

namespace Controllers{
    public class LogisticaController{
        public void Create(DateTime data, int quantidade, string produtoid, string estoqueid){
            if(data == null || quantidade == null || produtoid == null || produtoid.Length == 0 || estoqueid == null || estoqueid.Length == 0){
                throw new Exception("Logistica não identificada.");
            }
            new LogisticaModels(data, quantidade, produtoid, estoqueid);
        }

        public static List<LogisticaModels> Read(){
            return LogisticaModels.Read();   
        }

        public static LogisticaModels ReadById(int id){
            return LogisticaModels.ReadById(id);
        }
    }
}