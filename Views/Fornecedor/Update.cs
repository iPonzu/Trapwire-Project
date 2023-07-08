using Models;
using Controllers;

namespace Views{
    
    public class FornecedorUpdate : Form{
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

            this.lblcnpj = new Label();
            this.lblcnpj.Text = "CNPJ";
            this.lblcnpj.Location = new System.Drawing.Point(10, 70);
            this.lblcnpj.Size = new System.Drawing.Size(50, 20);

            this.txtcnpj = new TextBox();
            this.txtcnpj.Text = fornecedor.Cnpj;
            this.txtcnpj.Location = new System.Drawing.Point(80, 70);
            this.txtcnpj.Size = new System.Drawing.Size(150, 20);
            this.lblcnpj = new Label();
            this.lblcnpj.Text = "CNPJ";
            this.lblcnpj.Location = new System.Drawing.Point(10, 70);
            this.lblcnpj.Size = new System.Drawing.Size(50, 20);

            this.txtcnpj = new TextBox();
            this.txtcnpj.Text = fornecedor.Cnpj;
            this.txtcnpj.Location = new System.Drawing.Point(80, 70);
            this.txtcnpj.Size = new System.Drawing.Size(150, 20);

            this.btUpdateFornecedor = new Button();
            this.btUpdateFornecedor.Text = "Editar";
            this.btUpdateFornecedor.Location = new System.Drawing.Point(80, 260);
            this.btUpdateFornecedor.Size = new System.Drawing.Size(150, 35);
            this.btUpdateFornecedor.Click += new EventHandler(btUpdateFornecedor_Click);



         
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome); 
            this.Controls.Add(this.lblcnpj);  
            this.Controls.Add(this.txtcnpj);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome); 
            this.Controls.Add(this.lblcnpj);  
            this.Controls.Add(this.txtcnpj);

        }
    }
}