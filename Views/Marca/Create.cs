using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{
    public class MarcaCreate : Form{
        public Label lblMarcanome;
        public TextBox txtMarcanome;
        public Button btCadMarca;

        public void btCadMarca_Click(object sender, EventArgs e){
            if(txtMarcanome.Text == ""){
                MessageBox.Show("Preencha os campos!");
                return;
            }else{
                MarcaController.Create(txtMarcanome.Text);
                MessageBox.Show("Marca cadastrada com sucesso!");
                ClearForm();
            }
            MarcaView marcaList = Application.OpenForms.OfType<MarcaView>().FirstOrDefault();
            if(marcaList != null){
                marcaList.RefreshList();
            }
            this.Close();
        }

        private void ClearForm(){
            txtMarcanome.Clear();
        }

        public MarcaCreate()
        {
            this.Text = "Registrar Marca";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(344,200);

            this.lblMarcanome = new Label();
            this.lblMarcanome.Text = "Nome:";
            this.lblMarcanome.Location = new Point(10, 40);
            this.lblMarcanome.Size = new Size(70, 20);
            
            this.txtMarcanome = new TextBox();
            this.txtMarcanome.Location = new Point(90, 40);
            this.txtMarcanome.Size = new Size(150, 20);

            this.btCadMarca = new Button();
            this.btCadMarca.Text = "Cadastrar";
            this.btCadMarca.Location = new Point(90, 90);
            this.btCadMarca.Size = new Size(150, 25);
            this.btCadMarca.Click += new EventHandler(btCadMarca_Click);

            this.Controls.Add(lblMarcanome);           
            this.Controls.Add(txtMarcanome);
            this.Controls.Add(btCadMarca);
        }
    }
}