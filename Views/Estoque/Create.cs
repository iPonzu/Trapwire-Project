using Models;
using Controllers;
using System.Windows.Forms;

namespace Views{
    public class EstoqueCreate : Form{
        public Label lblEstoque;
        public TextBox txtEstoque;
        public Label lblEndereco;
        public TextBox txtEndereco;
        public Button btCadEstoque;

        public void btCadEstoque_Click(object sender, EventArgs e){
            if(txtEstoque.Text == "" || txtEndereco.Text == ""){
                MessageBox.Show("Preencha todos os campos!");
                return;
            }else{
                EstoqueController.Create(txtEstoque.Text, txtEndereco.Text);
                MessageBox.Show("Estoque cadastrado com sucesso!");
                ClearForm();
                this.Close();
                Menu.index();
            }

            EstoqueView estoqueList = Application.OpenForms.OfType<EstoqueView>().FirstOrDefault();
        }

        private void ClearForm(){
            txtEstoque.Clear();
            txtEndereco.Clear();
        }

        public EstoqueCreate(){
            
            this.Text = "Registrar estoque";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.Size = new System.Drawing.Size(344,250);
            
            this.lblEstoque = new Label();
            this.lblEstoque.Text = "Estoque:";
            this.lblEstoque.Location = new Point(10, 40);
            this.lblEstoque.Size = new Size(70, 20);

            this.txtEstoque = new TextBox();
            this.txtEstoque.Location = new Point(90, 40);
            this.txtEstoque.Size = new Size(150, 20);

            this.lblEndereco = new Label();
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.Location = new Point(10, 70);
            this.lblEndereco.Size = new Size(70, 20);

            this.txtEndereco = new TextBox();
            this.txtEndereco.Location = new Point(90, 70);
            this.txtEndereco.Size = new Size(150, 20);

            this.btCadEstoque = new Button();
            this.btCadEstoque.Text = "Cadastrar";
            this.btCadEstoque.Location = new Point(90, 120);
            this.btCadEstoque.Size = new Size(150, 25);
            this.btCadEstoque.Click += new EventHandler(btCadEstoque_Click);

            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btCadEstoque);

        }
    }
}