using Models;
using Controllers;

namespace Views{
    public class LogisticaView : Form{
        public enum Option {Update, Delete}

        ListView ListLogistica;

        private void AddListView (Models.LogisticaModels logistica){
            string [] row = {
                logistica.Data.ToString(),
                logistica.Quantidade.ToString(),
                logistica.Produtoid.ToString(),
                logistica.Estoqueid.ToString()
            };
        }
        public void RefreshList(){
            ListLogistica.Items.Clear();
            List<LogisticaModels> logisticas = LogisticaModels.Read();
            foreach (LogisticaModels logistica in logisticas){
                AddListView(logistica);
            }
        }

        public LogisticaModels GetSelectedLogistica(Option option){
            if(ListLogistica.SelectedItems.Count > 0){
                int selectedLogisticaId = int.Parse(ListLogistica.SelectedItems[0].Text);
                return Controllers.LogisticaController.ReadById(selectedLogisticaId);
            }else{
                throw new Exception($"Selecione uma Logistica para {(option == Option.Update ? "Update" : "Delete")}");
            }
        }

        
        public void btCadLogistica_Click (object sender, EventArgs e){
            var LogisticaCreate = new Views.LogisticaCreate();
            LogisticaCreate.Show();
        }
        
        public void btLogisticaUpdate_Click (object sender, EventArgs e){
            try{
                LogisticaModels logistica = GetSelectedLogistica(Option.Update);
                RefreshList();
                var LogisticaUpdate = new Views.LogisticaUpdate(logistica);
                if(LogisticaUpdate.ShowDialog() == DialogResult.OK){
                   RefreshList();
                   MessageBox.Show("Logistica Atualizada com sucesso"); 
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possível excluir a Logistica desejada" + ex.Message);
            }
        }
        
        private void btDelete_Click (object sender, EventArgs e){
            try{
                LogisticaModels Logistica = GetSelectedLogistica(Option.Delete);
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir esta Logistica agora?" , "Confirmar exlcusão", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes){
                    Controllers.LogisticaController.Delete(Convert.ToString(Logistica.Id));
                    RefreshList();
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possível excluir a Logistica" + ex.Message);
            }
        }

        private void btClose_Click (object sender, EventArgs e){
            this.Close();
        }
        public LogisticaView(){

        }
    }
}