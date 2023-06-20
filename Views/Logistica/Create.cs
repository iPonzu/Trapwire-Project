using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class LogisticaCreate : Form{

        public Label lblidlogistica;
        public TextBox txtidlogistica;
        public Label lblidproduto;
        public TextBox txtidproduto;
        public Label lblidarmazem;
        public TextBox txtidarmazem;
        public Label lbldata;
        public TextBox txtdata;
        public Label lblquantidade;
        public TextBox txtquantidade;
        public Label lbltipo;
        public TextBox txttipo;
        public Button btnCadLog;

        public void btCadLog_Click(object sender, EventArgs e){
            if (txtidlogistica.Text == "" || txtidproduto.Text == "" || txtidarmazem.Text == "" || txtdata.Text == "" || txttipo.Text == ""){
                MessageBox.Show("Preencha os campos");
                return;
            }else{
                LogisticaController.Create(txtidlogistica.Text);
                MessageBox.Show("Logistica criada com sucesso.");
            }
        }

        public LogisticaCreate() {
        
        
        }
    }
}