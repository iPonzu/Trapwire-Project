using Models;
using Controllers;

namespace Views{
    
    public class FornecedorUpdate : Form{

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
        public Button btUpdateFornecedor;

        public FornecedorModels fornecedor;

        private void btUpdateFornecedor_Click(object sender, EventArgs e){
            FornecedorModels fornecedorToEdito = this.fornecedor;
        }

    }

}