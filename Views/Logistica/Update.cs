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

            this.Text = "Editar Estoque";
            this.Size = new System.Drawing.Size(280, 360);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            
            this.lbldata = new Label();
            this.lbldata.Text = "Data";
            this.lbldata.Location = new System.Drawing.Point(10, 40);
            this.lbldata.Size = new System.Drawing.Size(50, 20);

            this.txtdata = new TextBox();
            this.txtdata.Location = new System.Drawing.Point(80, 40);
            this.txtdata.Size = new System.Drawing.Size(150, 20);

            this.lblquantidade = new Label();
            this.lblquantidade.Text = "Quantidade";
            this.lblquantidade.Location = new System.Drawing.Point(10, 70);
            this.lblquantidade.Size = new System.Drawing.Size(50, 20);

            this.txtquantidade = new TextBox();
            this.txtquantidade.Location = new System.Drawing.Point(80, 70);
            this.txtquantidade.Size = new System.Drawing.Size(150, 20);

            this.btUpdateLogistica = new Button();
            this.btUpdateLogistica.Text = "Editar";
            this.btUpdateLogistica.Location = new System.Drawing.Point(80, 260);
            this.btUpdateLogistica.Size = new System.Drawing.Size(150, 35);
            this.btUpdateLogistica.Click += new EventHandler(btUpdate_Click);

            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.btUpdateLogistica);
        }
    }
}