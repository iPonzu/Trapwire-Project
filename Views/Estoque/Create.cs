using Models;
using Controllers;

namespace Views{
    public class EstoqueCreate : Form{
        public Label lblEstoque;
        public TextBox txtEstoque;
        public Label lblendereco;
        public TextBox txtendereco;
        public Button btCadEstoque;

        public void btCadEstoque_Click(object sender, EventArgs e){
            if(txtEstoque == null || txtendereco.Text == null){
                MessageBox.Show("Preencha todos os campos");
                return;
            }else{
                EstoqueController.Create(txtEstoque.Text, txtendereco.Text);
            }
        }

        public EstoqueCreate(){

        }
    }
}