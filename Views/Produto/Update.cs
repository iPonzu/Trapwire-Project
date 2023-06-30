using Controllers;
using Models;
using System;

namespace Views{

    public class ProdutoUpdate : Form{

        public Label lblModelo;
        public TextBox txtModelo;
        public Label lblCategoria;
        public TextBox txtCategoria;
        public Button btUpdateProduto;

        public ProdutoModels produto;

        private void btUpdate_Click(object sender, EventArgs e){
            ProdutoModels produtoToUpdate = this.produto;
        }
        public ProdutoUpdate(ProdutoModels produto){
            this.produto = produto;

            this.Text = "Editar produto";
            this.Size = new System.Drawing.Size(280, 360);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;

            this.lblModelo = new Label();
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Location = new Point(10, 40);
            this.lblModelo.Size = new Size(50, 20);

            this.txtModelo = new TextBox();
            this.txtModelo.Text = produto.Modeloid;
            this.txtModelo.Location = new System.Drawing.Point(80, 40);
            this.txtModelo.Size = new System.Drawing.Size(150, 20);

            this.lblCategoria = new Label();
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Location = new Point(10, 70);
            this.lblCategoria.Size = new Size(50, 20);

            this.txtCategoria = new TextBox();
            this.txtCategoria.Text = produto.Categoriaid;
            this.txtCategoria.Location = new System.Drawing.Point(80, 70);
            this.txtCategoria.Size = new System.Drawing.Size(150, 20);

            this.btUpdateProduto = new Button();
            this.btUpdateProduto.Text = "Editar";
            this.btUpdateProduto.Location = new System.Drawing.Point(80, 260);
            this.btUpdateProduto.Size = new System.Drawing.Size(150, 35);
            this.btUpdateProduto.Click += new EventHandler(btUpdate_Click);
        
            this.Controls.Add(this.txtModelo);   
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btUpdateProduto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblModelo);
        
        }
    }
}
