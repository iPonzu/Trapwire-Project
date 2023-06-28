using Models;
using Controllers;

namespace Views{
    public class EstoqueCreate : Form{
        public Label lblEstoque;
        public TextBox txtEstoque;
        public Label lblEndereco;
        public TextBox txtEndereco;
        public Button btCadEstoque;

        public void btCadEstoque_Click(object sender, EventArgs e){
            if(txtEstoque == null || txtEndereco.Text == null){
                MessageBox.Show("Preencha todos os campos");
                return;
            }else{
                EstoqueController.Create(txtEstoque.Text, txtEndereco.Text);
            }
        }

        public EstoqueCreate(){

        }
    }
}