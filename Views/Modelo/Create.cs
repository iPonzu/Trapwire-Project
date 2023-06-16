using Controllers;
using Models;
namespace Views{

    public class ModeloCreate : Form{
        
        public Label lblidmodelo;
        public TextBox txtidmodelo;
        public Label lblmodelo;
        public TextBox txtNomemodelo;
        public Button btCadModelo;


          public void btCadModelo_Click(object sender, EventArgs e) {
            if (txtNomemodelo.Text == "") {
                MessageBox.Show("Preencha os campos");
                return;
            } else {
                ModeloModels modelo = new ModeloModels(
                    Convert.ToString(txtNomemodelo)
                    );
                ModeloController controller = new ModeloController();
                ModeloController.Create(modelo);

                MessageBox.Show("Modelo criado com sucesso");
                
            }
        }


        public ModeloCreate()
        {
            this.Text = "Registrar Modelo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            Size = new System.Drawing.Size(251,200);

            this.lblidmodelo = new Label();
            this.lblidmodelo.Text = "Id:";
            this.lblidmodelo.Location = new Point(10, 50); // Horizontal, Vertical
            this.lblidmodelo.Size = new Size(50, 20); // Largura, Altura

            this.txtidmodelo = new TextBox();  
            this.txtidmodelo.Location = new Point(80, 40);
            this.txtidmodelo.Size = new Size(150, 20);

            this.lblmodelo = new Label();
            this.lblmodelo.Text = "Modelo:";
            this.lblidmodelo.Location = new Point(10, 70);
            this.lblidmodelo.Size = new Size(50, 20);

            this.txtNomemodelo = new TextBox();
            this.txtNomemodelo.Location = new Point(80, 70);
            this.txtNomemodelo.Size = new Size(150, 20);

            this.btCadModelo = new Button();
            this.btCadModelo.Text = "Cadastrar";
            this.btCadModelo.Location = new Point(10, 130);
            this.btCadModelo.Size = new Size(70, 20);


            this.Controls.Add(this.lblidmodelo);
            this.Controls.Add(this.txtidmodelo);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.txtNomemodelo);
            this.Controls.Add(this.btCadModelo);
        }
    }
}