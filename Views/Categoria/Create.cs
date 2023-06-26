using Controllers;
using Models;
using System.Windows.Forms;

namespace Views {

    public class CategoriaCreate : Form {

        public Label lblcategorianome;
        public TextBox txtCategorianome;
        public Button btCadCategoria;

        public void btCadCategoria_Click(object sender, EventArgs e) {
            if(txtCategorianome.Text == ""){
                MessageBox.Show("Preencha o nome");
                return;
            } else {
                CategoriaController.Create(txtCategorianome.Text);
            }
        }

        public CategoriaCreate() 
        {
            Text = "Registrar Categoria";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(251,200);
            
            lblcategorianome = new Label();
            lblcategorianome.Text = "Nome:";
            lblcategorianome.Location = new Point(10, 50);
            lblcategorianome.Size = new Size(50, 20);
            
            txtCategorianome = new TextBox();
            txtCategorianome.Location = new Point(80, 50);
            txtCategorianome.Size = new Size(100, 20);

            btCadCategoria = new Button();
            btCadCategoria.Text = "Cadastrar";
            btCadCategoria.Location = new Point(10, 100);
            btCadCategoria.Size = new Size(70, 20);

            Controls.Add(lblcategorianome);
            Controls.Add(txtcategorianome);
        }
    }
}