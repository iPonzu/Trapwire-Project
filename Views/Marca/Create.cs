using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class MarcaCreate : Form{
        
        public Label lblidmarca;
        public TextBox txtidmarca;
        public Label lblmarca;
        public TextBox txtmarca;
        public Button btMarca;

        public MarcaCreate()
        {
            this.Text = "Registrar Marca";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(280, 360);

            this.lblidmarca = new Label();
            this.lblidmarca.Text = "ID:";
            this.lblidmarca.Location = new Point(10, 50); // Horizontal, Vertical
            this.lblidmarca.Size = new Size(50, 20); // Largura, Altura

            this.txtidmarca = new TextBox();  
            this.txtidmarca.Location = new Point(80, 40);
            this.txtidmarca.Size = new Size(150, 20);

            this.lblmarca = new Label();
            this.lblmarca.Text = "Marca:";
            this.lblidmarca.Location = new Point(10, 70);
            this.lblidmarca.Size = new Size(50, 20);

            this.txtmarca = new TextBox();
            this.txtmarca.Location = new Point(80, 70);
            this.txtmarca.Size = new Size(150, 20);

            this.btMarca = new Button();
            this.btMarca.Text = "Cadastrar";
            this.btMarca.Location = new Point(10, 130);
            this.btMarca.Size = new Size(70, 20);


            this.Controls.Add(this.lblidmarca);
            this.Controls.Add(this.txtidmarca);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.btMarca);
        }
    }
}