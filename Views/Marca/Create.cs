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
                MessageBox.Show("Preencha os campos");
                return;
            } else{
                MarcaController.Create(txtMarcanome.Text);
                MessageBox.Show("Marca cadastrada com sucesso.");
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
            Text = "Registrar Marca";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(251,200);

            lblMarcanome = new Label();
            lblMarcanome.Text = "Nome:";
            lblMarcanome.Location = new Point(10, 20);
            lblMarcanome.Size = new Size(50, 30);
            
            txtMarcanome = new TextBox();
            txtMarcanome.Location = new Point(80, 50);
            txtMarcanome.Size = new Size(100, 20);

            btCadMarca = new Button();
            btCadMarca.Text = "Cadastrar";
            btCadMarca.Location = new Point(10, 100);
            btCadMarca.Size = new Size(70, 20);

            Controls.Add(lblMarcanome);           
            Controls.Add(txtMarcanome);
            Controls.Add(btCadMarca);
            
        }
    }
}