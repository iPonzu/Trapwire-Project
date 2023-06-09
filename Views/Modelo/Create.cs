using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ModeloCreate : Form{
        public Label lblNomemodelo;
        public TextBox txtNomemodelo;
        public Button btCadModelo;
        
        public void btCadModelo_Click(object sender, EventArgs e){
            if(txtNomemodelo.Text == ""){
                MessageBox.Show("Preencha os campos!");
                return;
            }else{
                ModeloController.Create(txtNomemodelo.Text);
                MessageBox.Show("Marca cadastrada com sucesso!");
                ClearForm();
            }
            ModeloView ListModelo = Application.OpenForms.OfType<ModeloView>().FirstOrDefault();
            if(ListModelo != null){
                ListModelo.RefreshList();
            }
            this.Close();
        }

        private void ClearForm(){
            txtNomemodelo.Clear();
        }


        public ModeloCreate(){
            this.Text = "Registrar Modelo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(344,200);

            this.lblNomemodelo = new Label();
            this.lblNomemodelo.Text = "Modelo:";
            this.lblNomemodelo.Location = new Point(10, 40);
            this.lblNomemodelo.Size = new Size(50, 20);

            this.txtNomemodelo = new TextBox();
            this.txtNomemodelo.Location = new Point(90, 40);
            this.txtNomemodelo.Size = new Size(150, 20);

            this.btCadModelo = new Button();
            this.btCadModelo.Text = "Cadastrar";
            this.btCadModelo.Location = new Point(90, 90);
            this.btCadModelo.Size = new Size(150, 25);
            this.btCadModelo.Click +=  new EventHandler(btCadModelo_Click);

            this.Controls.Add(lblNomemodelo);
            this.Controls.Add(txtNomemodelo);
            this.Controls.Add(btCadModelo);
        }
    }
}