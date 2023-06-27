using Controllers;
using Models;

namespace Views{
    public class LogisticaCreate : Form{
        public Label lblid;
        public TextBox txtid;
        public Label lblLog;
        public TextBox txtLog;
        public Label lbldate;
        public TextBox txtdate;
        public Label lblquantidade;
        public TextBox txtquantidade;
        public Label lblproduto;
        public TextBox txtproduto;
        public Label lblestoque;
        public TextBox txtestoque;
        public Button btCadLog;

        
        public void btCadLog_Click(object sender, EventArgs e){
            if(txtLog.Text == "" || txtdate.Text == "" || txtquantidade.Text == "" || txtestoque.Text == "" || txtproduto.Text == ""){
                MessageBox.Show("Preencha os campos");
                return;
            }else{
                LogisticaController.Create(txtdate.Text, int.Parse(txtquantidade.Text) ,txtproduto.Text, txtestoque.Text);
            }
        }
        
        public LogisticaCreate(){
            
        }
    }
}