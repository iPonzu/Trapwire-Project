using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{
    public class MarcaCreate : Form{
        public Label lblidmarca;
        public TextBox txtidmarca;
        public Label lblmarcanome;
        public TextBox txtmarcanome;
        public Button btMarcaCreate;

        public MarcaCreate()
        {
            Text = "Registrar Marca";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(251,200);

            lblidmarca = new Label();
            lblidmarca.Text = "ID:";
            lblidmarca.Location = new Point(10, 20);
            lblidmarca.Size = new Size(20, 20);   

            txtidmarca = new TextBox();  
            txtidmarca.Location = new Point(80, 20);
            txtidmarca.Size = new Size(50, 30);

            lblmarcanome = new Label();
            lblmarcanome.Text = "Nome:";
            lblmarcanome.Location = new Point(10, 50);
            lblmarcanome.Size = new Size(50, 20);
            
            txtmarcanome = new TextBox();
            txtmarcanome.Location = new Point(80, 50);
            txtmarcanome.Size = new Size(100, 20);

            btMarcaCreate = new Button();
            btMarcaCreate.Text = "Cadastrar";
            btMarcaCreate.Location = new Point(10, 100);
            btMarcaCreate.Size = new Size(70, 20);

            Controls.Add(lblidmarca);
            Controls.Add(txtidmarca);
            Controls.Add(lblmarcanome);           
            Controls.Add(txtmarcanome);
            Controls.Add(btMarcaCreate);
            

        }
    }
}