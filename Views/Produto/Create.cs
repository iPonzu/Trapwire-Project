using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ProdutoCreate : Form {
        
        public Label lblidprod;
        public TextBox txtidProd;
        public Label lblModelo;
        public TextBox txtModelo;
        public Label lblproduto;
        public TextBox txtProduto;
        public Label lblcategoria;
        public TextBox txtCategoria;
        public Button btCadProduto;

        public void btCadProduto_Click(object sender, EventArgs e) {
            if (txtProduto.Text == "" || txtModelo.Text == "" || txtCategoria.Text == "") {
                MessageBox.Show("Preencha os campos!");
                return;
            } else {
                ProdutoController.Create(txtModelo.Text, txtCategoria.Text);
                MessageBox.Show("Produto criado com sucesso!");  
            }
            ProdutoView ListProduto = Application.OpenForms.OfType<ProdutoView>().FirstOrDefault();
            if (ListProduto != null) {
                ListProduto.RefreshList();
            }
            this.Close();
        }


        public ProdutoCreate(){
            Text = "Registrar Produto";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(344, 280);

            this.lblidprod = new Label();
            this.lblidprod.Text = "ID:";
            this.lblidprod.Location = new Point(10, 20);
            this.lblidprod.Size = new Size(20, 20);
        
            this.txtidProd = new TextBox();  
            this.txtidProd.Location = new Point(90, 20);
            this.txtidProd.Size = new Size(150, 30);

            this.lblModelo = new Label();
            this.lblModelo.Text = "Marca:";
            this.lblModelo.Location = new Point(10, 50);
            this.lblModelo.Size = new Size(50, 20);

            this.txtModelo = new TextBox();
            this.txtModelo.Location = new Point(90, 50);
            this.txtModelo.Size = new Size(150, 20);

            this.lblproduto = new Label();
            this.lblproduto.Text = "Modelo:";
            this.lblproduto.Location = new Point(10, 80);
            this.lblproduto.Size = new Size(50, 20);

            this.txtProduto = new TextBox();
            this.txtProduto.Location = new Point(90, 80);
            this.txtProduto.Size = new Size(150, 20);

            this.lblcategoria = new Label();
            this.lblcategoria.Text = "Categoria:";
            this.lblcategoria.Location = new Point(10, 110);
            this.lblcategoria.Size = new Size(70, 20);

            this.txtCategoria = new TextBox();
            this.txtCategoria.Location = new Point(90, 110);
            this.txtCategoria.Size = new Size(150, 20);

            this.btCadProduto = new Button();
            this.btCadProduto.Text = "Cadastrar";
            this.btCadProduto.Location = new Point(90, 160);
            this.btCadProduto.Size = new Size(150, 25);
            this.btCadProduto.Click += new EventHandler (btCadProduto_Click);


            this.Controls.Add(lblidprod);
            this.Controls.Add(txtidProd);
            this.Controls.Add(lblModelo);
            this.Controls.Add(txtModelo);
            this.Controls.Add(lblcategoria);
            this.Controls.Add(txtCategoria);
            this.Controls.Add(lblproduto);
            this.Controls.Add(txtProduto);
            this.Controls.Add(btCadProduto);
        }
    }   
}
