using Controllers;
using Models;

namespace Views{
    public class LogisticaCreate : Form{
        public Label lblId;
        public TextBox txtId;
        public Label lblLog;
        public TextBox txtLog;
        public Label lblDate;
        public TextBox txtDate;
        public Label lblQuantidade;
        public TextBox txtQuantidade;
        public Label lblProduto;
        public TextBox txtProduto;
        public Label lblEstoque;
        public TextBox txtEstoque;
        public Button btCadLogistica;

        
        public void btCadLog_Click(object sender, EventArgs e){
            if(txtLog.Text == "" || txtDate.Text == "" || txtQuantidade.Text == "" || txtEstoque.Text == "" || txtProduto.Text == ""){
                MessageBox.Show("Preencha os campos");
                return;
            }else{
                LogisticaController.Create(txtDate.Text, int.Parse(txtQuantidade.Text) ,txtProduto.Text, txtEstoque.Text);
                MessageBox.Show("Logistica cadastrada com sucesso");
                ClearForm();
            }
            LogisticaView logisticaList = Application.OpenForms.OfType<LogisticaView>().FirstOrDefault();
            if(logisticaList != null){
                logisticaList.RefreshList();
            }
            this.Close();
        }

        private void ClearForm(){
            txtDate.Clear();
            txtEstoque.Clear();
            txtLog.Clear();
            txtProduto.Clear();
        }
        
        public LogisticaCreate(){
            Text = "Registrar Logística";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(273,368);
        
        
        
        
        }
    }
}