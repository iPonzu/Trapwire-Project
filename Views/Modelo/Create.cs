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
                ClearForm();
            }
            ModeloView modeloList = Application.OpenForms.OfType<ModeloView>().FirstOrDefault();
        }

        private void ClearForm() {
            txtNomemodelo.Clear();
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

            this.lblNomemodelo = new Label();
            this.lblNomemodelo.Text = "Modelo:";
            this.lblNomemodelo.Location = new Point(10, 40); // Horizontal, Vertical
            this.lblNomemodelo.Size = new Size(50, 20); // Largura, Altura

            this.txtNomemodelo = new TextBox();
            this.txtNomemodelo.Location = new Point(80, 40);
            this.txtNomemodelo.Size = new Size(150, 20);

            this.btCadModelo = new Button();
            this.btCadModelo.Text = "Cadastrar";
            this.btCadModelo.Location = new Point(10, 130);
            this.btCadModelo.Size = new Size(70, 20);
            this.btCadModelo.Click +=  new EventHandler(btCadModelo_Click);

            Controls.Add(this.lblNomemodelo);
            Controls.Add(this.txtNomemodelo);
            Controls.Add(this.btCadModelo);
        }
    }
}