using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ProdutoCreate : Form {
        
        public Label lblidprod;
        public TextBox txtidprod;
        public Label lblmarca;
        public TextBox txtmarca;
        public Label lblproduto;
        public TextBox txtproduto;
        public Label lblcategoria;
        public TextBox txtcategoria;
        public Button btProdutoCreate;

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
        
            txtidprod = new TextBox();  
            txtidprod.Location = new Point(80, 20);
            txtidprod.Size = new Size(50, 30);

            lblmarca = new Label();
            lblmarca.Text = "Marca:";
            lblmarca.Location = new Point(10, 50);
            lblmarca.Size = new Size(50, 20);

            txtmarca = new TextBox();
            txtmarca.Location = new Point(80, 50);
            txtmarca.Size = new Size(100, 20);

            lblproduto = new Label();
            lblproduto.Text = "Modelo:";
            lblproduto.Location = new Point(10, 80);
            lblproduto.Size = new Size(50, 20);

            txtproduto = new TextBox();
            txtproduto.Location = new Point(80, 80);
            txtproduto.Size = new Size(80, 20);

            lblcategoria = new Label();
            lblcategoria.Text = "Categoria:";
            lblcategoria.Location = new Point(10, 110);
            lblcategoria.Size = new Size(70, 20);

            txtcategoria = new TextBox();
            txtcategoria.Location = new Point(80, 110);
            txtcategoria.Size = new Size(150, 20);

            /* buttons */
            btProdutoCreate = new Button();
            btProdutoCreate.Text = "Cadastrar";
            btProdutoCreate.Location = new Point(10, 150);
            btProdutoCreate.Size = new Size(70, 20);

            Controls.Add(lblidprod);
            Controls.Add(txtidprod);
            Controls.Add(lblmarca);
            Controls.Add(txtmarca);
            Controls.Add(lblcategoria);
            Controls.Add(txtcategoria);
            Controls.Add(lblproduto);
            Controls.Add(txtproduto);
            Controls.Add(btProdutoCreate);
        }
    }   
}
