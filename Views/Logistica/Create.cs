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
        public Label lblprodutoid;
        public TextBox txtprodutoid;
        public Label lblestoqueid;
        public TextBox txtestoqueid;
        public Button btCadLog;

        
        public void btCadLog_Click(object sender, EventArgs e){
            if(txtLog.Text == "" || txtdate.Text == ""){
                MessageBox.Show("Preencha os campos");
                return;
            }else{
                LogisticaController.Create(txtLog.Text);
            }
        }
        
        public LogisticaCreate(){
            
        }
    }
}