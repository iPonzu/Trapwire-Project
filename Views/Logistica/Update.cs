using Controllers;
using Models;
using System;

namespace Views {

    public class LogisticaUpdate : Form {
    
        public Label lbldata;
        public TextBox txtdata;
        public Label lblquantidade;
        public TextBox txtquantidade;
        public Button btUpdateLogistica;

        public LogisticaModels logistica;

        // private void btUpdateLog_Click(object sender, EventArgs e) {
        //     LogisticaModels logisticaToUpdate = this.Logistica;
        //     logisticaToUpdate.Id = int.Parse(this.txtid.Text);
        //     Controllers.LogisticaController.Update(logisticaToUpdate);
        
        //     ListLogistica logisticaList = Application.OpenForms.OfType<ListLogistica>().FirstOrDefault();
        
        //     if (logisticaList != null){
        //         logisticaList.RefreshList();
        //     }
        //     this.Close();
        // }

            private void btUpdate_Click(object sender, EventArgs e) {
                LogisticaModels logisticaToUpdate = this.logistica;
                logisticaToUpdate.Data = this.txtdata.Text;
                logisticaToUpdate.Quantidade = int.Parse(this.txtquantidade.Text);
                try{
                    if(logisticaToUpdate.Data == "" || logisticaToUpdate.Quantidade == 0){
                        MessageBox.Show("Preencha os campos");
                        return;
                    }else{
                        LogisticaModels.Update(logisticaToUpdate);
                        MessageBox.Show("Logistica modificada.");
                        
                    }
                    this.Close();
                }catch (System.Exception err){
                    throw err;
                }
                
            }

        public LogisticaUpdate(LogisticaModels logistica){
            this.logistica = logistica;



        
        
        }
    }
}