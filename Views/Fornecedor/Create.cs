using Controllers;
using Models;

namespace Views{
    public class FornecedorCreate : Form{
        public Label lblidfornecedor;
        public TextBox txtidfornecedor;
        public Label lblNomefornecedor;
        public TextBox txtNomefornecedor;
        public Label lblNomeSocial;
        public TextBox txtNomeSocial;
        public Label lblcnpj;
        public TextBox txtcnpj;
        public Label lblEndereco;
        public TextBox txtEndereco;
        public Label lblTelefone;
        public TextBox txtTelefone;
        public Button btCadFornecedor;


        public void btCadFornecedore_Click(object sender, EventArgs e){
            if(txtNomefornecedor.Text == "" || txtNomeSocial.Text == "" || txtEndereco.Text == "" || txtTelefone.Text == "" || txtcnpj.Text == ""){
                MessageBox.Show("Preencha os campos");
                return;
            }else{
                FornecedorController.Create(txtNomefornecedor.Text,txtNomeSocial.Text, txtEndereco.Text, txtTelefone.Text, txtcnpj.Text);
            }
        } 

        public FornecedorCreate(){
            
        }   

    }
}