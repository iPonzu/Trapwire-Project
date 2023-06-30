using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ModeloCreate : Form{
        public Label lblNomemodelo;
        public TextBox txtNomemodelo;
        public Button btCadModelo;
        
          public void btCadModelo_Click(object sender, EventArgs e) {
            if (txtNomemodelo.Text == "") {
                MessageBox.Show("Preencha os campos");
                return;
            } else {
                ModeloController.Create(txtNomemodelo.Text);
                MessageBox.Show("Modelo criado com sucesso");  
            }
        }


        public ModeloCreate(){
            Text = "Registrar Modelo";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(251,200);

            lblNomemodelo = new Label();
            lblNomemodelo.Text = "Modelo:";
            lblNomemodelo.Location = new Point(10, 40); // Horizontal, Vertical
            lblNomemodelo.Size = new Size(50, 20); // Largura, Altura

            txtNomemodelo = new TextBox();
            txtNomemodelo.Location = new Point(80, 40);
            txtNomemodelo.Size = new Size(150, 20);

            btCadModelo = new Button();
            btCadModelo.Text = "Cadastrar";
            btCadModelo.Location = new Point(10, 130);
            btCadModelo.Size = new Size(70, 20);
            btCadModelo.Click += btCadModelo_Click;

            Controls.Add(lblNomemodelo);
            Controls.Add(txtNomemodelo);
            Controls.Add(btCadModelo);
        }
    }
}