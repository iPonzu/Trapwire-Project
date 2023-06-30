using Models;
using Controllers;

namespace Views{
    
    public class FornecedorUpdate : Form{

        public Label lblId;
        public TextBox txtId;
        public Label lblNome;
        public TextBox txtNome;
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
            FornecedorModels fornecedorToUpdate = this.fornecedor;
            fornecedorToUpdate.Id = int.Parse(this.txtId.Text);
            fornecedorToUpdate.Nome = this.txtNome.Text;
            fornecedorToUpdate.Cnpj = this.txtcnpj.Text;
            fornecedorToUpdate.Telefone = this.txtTelefone.Text;
            fornecedorToUpdate.Endereco = this.txtEndereco.Text;
            fornecedorToUpdate.NomeSocial = this.txtNomeSocial.Text;

            
            try{
                if(fornecedorToUpdate.Id == 0 || fornecedorToUpdate.Nome == null || fornecedorToUpdate.Cnpj == null || fornecedorToUpdate.Telefone == null || fornecedorToUpdate.Endereco == null){
                    MessageBox.Show("Preencha os campos!");
                    return;    
                }else{
                    FornecedorModels.Update(fornecedorToUpdate);
                    MessageBox.Show("Fornecedor modificado.");
                }
                this.Close();
            }catch(Exception ex){
                throw ex;
                
            }
            
        }

        public FornecedorUpdate(FornecedorModels fornecedor){
            this.fornecedor = fornecedor;
        }

    }

}