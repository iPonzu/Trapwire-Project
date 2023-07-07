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
            fornecedorToUpdate.Id = (this.txtId.Text.ToString() == "" ? 0 : int.Parse(this.txtId.Text));
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
            
            this.Text = "Editar Fornecedor";
            this.Size = new System.Drawing.Size(280, 360);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new System.Drawing.Point(10, 40);
            this.lblNome.Size = new System.Drawing.Size(50, 20);

            this.txtNome = new TextBox();
            this.txtNome.Text = fornecedor.Nome;
            this.txtNome.Location = new System.Drawing.Point(80, 40);
            this.txtNome.Size = new System.Drawing.Size(150, 20);

            this.lblCnpj = new Label();
            this.lblCnpj.Text = "CNPJ";
            this.lblCnpj.Location = new System.Drawing.Point(10, 70);
            this.lblCnpj.Size = new System.Drawing.Size(50, 20);

            this.txtCnpj = new TextBox();
            this.txtCnpj.Text = fornecedor.Cnpj;
            this.txtCnpj.Location = new System.Drawing.Point(80, 70);
            this.txtCnpj.Size = new System.Drawing.Size(150, 20);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new System.Drawing.Point(10, 70);
            this.lblTelefone.Size = new System.Drawing.Size(50, 20);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Text = fornecedor.Telefone;
            this.txtTelefone.Location = new System.Drawing.Point(80, 70);
            this.txtTelefone.Size = new System.Drawing.Size(150, 20);

            this.lblEndereco = new Label();
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.Location = new System.Drawing.Point(10, 70);
            this.lblEndereco.Size = new System.Drawing.Size(50, 20);

            this.txtEndereco = new TextBox();
            this.txtEndereco.Text = fornecedor.Endereco;
            this.txtEndereco.Location = new System.Drawing.Point(80, 70);
            this.txtEndereco.Size = new System.Drawing.Size(150, 20);

            this.lblNomeSocial = new Label();
            this.lblNomeSocial.Text = "Nome Social";
            this.lblNomeSocial.Location = new System.Drawing.Point(10, 70);
            this.lblNomeSocial.Size = new System.Drawing.Size(50, 20);

            this.txtNomeSocial = new TextBox();
            this.txtNomeSocial.Text = fornecedor.NomeSocial;
            this.txtNomeSocial.Location = new System.Drawing.Point(80, 70);
            this.txtNomeSocial.Size = new System.Drawing.Size(150, 20);

            this.btUpdateFornecedor = new Button();
            this.btUpdateFornecedor.Text = "Editar";
            this.btUpdateFornecedor.Location = new System.Drawing.Point(80, 260);
            this.btUpdateFornecedor.Size = new System.Drawing.Size(150, 35);
            this.btUpdateFornecedor.Click += new EventHandler(btUpdate_Click);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome); 
            this.Controls.Add(this.lblCnpj);  
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblTelefone);  
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblNomeSocial);
            this.Controls.Add(this.txtNomeSocial);
            this.Controls.Add(this.btUpdateFornecedor);
        }
    }
}