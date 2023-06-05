using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ProdutoCreate : Form {
        
        public Label lblid;
        public TextBox txtid;
        public Label lblmarca;
        public TextBox txtmarca;
        public Label lblcategoria;
        public TextBox txtcategoria;
        public Button btCadt;

        public ProdutoCreate()
        {
            this.Text = "Registrar Produto";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(280, 360);

            this.lblid = new Label();
            this.lblid.Text = "Id:";
            this.lblid.Location = new Point(10, 50); 
            this.lblid.Size = new Size(50, 20); 

            this.txtid = new TextBox();  
            this.txtid.Location = new Point(80, 40);
            this.txtid.Size = new Size(150, 20);

            this.lblmarca = new Label();
            this.lblmarca.Text = "marca:";
            this.lblid.Location = new Point(10, 70);
            this.lblid.Size = new Size(50, 20);

            this.txtmarca = new TextBox();
            this.txtmarca.Location = new Point(80, 70);
            this.txtmarca.Size = new Size(150, 20);

            this.lblcategoria = new Label();
            this.lblcategoria.Text = "categoria:";
            this.lblid.Location = new Point(10, 70);
            this.lblid.Size = new Size(50, 20);

            this.txtcategoria = new TextBox();
            this.txtcategoria.Location = new Point(80, 70);
            this.txtcategoria.Size = new Size(150, 20);

            this.btCadt = new Button();
            this.btCadt.Text = "Cadastrar";
            this.btCadt.Location = new Point(10, 130);
            this.btCadt.Size = new Size(70, 20);

            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.btCadt);
        }
    }
    
}
