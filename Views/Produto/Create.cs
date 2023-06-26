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
                MessageBox.Show("Preencha os campos");
                return;
            } else {
                ProdutoController.Create(txtModelo.Text, txtCategoria.Text);
                MessageBox.Show("Produto criado com sucesso");  
            }
        }

        public ProdutoCreate()
        {
            Text = "Registrar Produto";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(280, 360);

            lblidprod = new Label();
            lblidprod.Text = "ID:";
            lblidprod.Location = new Point(10, 20); // Horizontal, Vertical
            lblidprod.Size = new Size(20, 20); // Largura, Altura
        
            txtidProd = new TextBox();  
            txtidProd.Location = new Point(80, 20);
            txtidProd.Size = new Size(50, 30);

            lblModelo = new Label();
            lblModelo.Text = "Marca:";
            lblModelo.Location = new Point(10, 50);
            lblModelo.Size = new Size(50, 20);

            txtModelo = new TextBox();
            txtModelo.Location = new Point(80, 50);
            txtModelo.Size = new Size(100, 20);

            lblproduto = new Label();
            lblproduto.Text = "Modelo:";
            lblproduto.Location = new Point(10, 80);
            lblproduto.Size = new Size(50, 20);

            txtProduto = new TextBox();
            txtProduto.Location = new Point(80, 80);
            txtProduto.Size = new Size(80, 20);

            lblcategoria = new Label();
            lblcategoria.Text = "Categoria:";
            lblcategoria.Location = new Point(10, 110);
            lblcategoria.Size = new Size(70, 20);

            txtCategoria = new TextBox();
            txtCategoria.Location = new Point(80, 110);
            txtCategoria.Size = new Size(150, 20);

            btCadProduto = new Button();
            btCadProduto.Text = "Cadastrar";
            btCadProduto.Location = new Point(10, 150);
            btCadProduto.Size = new Size(70, 20);
            btCadProduto.Click += (sender, e) =>{

            };

            Controls.Add(lblidprod);
            Controls.Add(txtidProd);
            Controls.Add(lblModelo);
            Controls.Add(txtModelo);
            Controls.Add(lblcategoria);
            Controls.Add(txtCategoria);
            Controls.Add(lblproduto);
            Controls.Add(txtProduto);
            Controls.Add(btCadProduto);
        }
    }   
}
