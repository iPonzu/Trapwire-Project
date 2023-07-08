using Models;
using Controllers;

namespace Views{
    public class EstoqueUpdate : Form{

        public Label lblNome;
        public TextBox txtNome;
        public Label lblEndereco;
        public TextBox txtEndereco;
        public Button btUpdateEstoque;
        public EstoqueModels estoque;

        private void btUpdate_Click(object sender, EventArgs e){
            EstoqueModels estoqueToUpdate = this.estoque;
            estoqueToUpdate.Nome = this.txtNome.Text;
            estoqueToUpdate.Endereco = this.txtEndereco.Text;

            try{
                if(estoqueToUpdate.Id == 0 || estoqueToUpdate.Nome == null || estoqueToUpdate.Endereco == null){
                    MessageBox.Show("Preencha os campos!");
                    return;
                }else{
                    EstoqueModels.Update(estoqueToUpdate);
                    MessageBox.Show("Estoque modificado.");
                }
                this.Close();
            }catch(Exception ex){
                throw ex;
            }
        }
        public EstoqueUpdate(EstoqueModels estoque) {
            this.estoque = estoque;

            this.Text = "Editar Estoque";
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
            this.txtNome.Text = estoque.Nome;
            this.txtNome.Location = new System.Drawing.Point(80, 40);
            this.txtNome.Size = new System.Drawing.Size(150, 20);

            this.lblEndereco = new Label();
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.Location = new System.Drawing.Point(10, 70);
            this.lblEndereco.Size = new System.Drawing.Size(50, 20);

            this.txtEndereco = new TextBox();
            this.txtEndereco.Text = estoque.Endereco;
            this.txtEndereco.Location = new System.Drawing.Point(80, 70);
            this.txtEndereco.Size = new System.Drawing.Size(150, 20);

            this.btUpdateEstoque = new Button();
            this.btUpdateEstoque.Text = "Editar";
            this.btUpdateEstoque.Location = new System.Drawing.Point(80, 260);
            this.btUpdateEstoque.Size = new System.Drawing.Size(150, 35);
            this.btUpdateEstoque.Click += new EventHandler(btUpdate_Click);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btUpdateEstoque);
        }
    }
}