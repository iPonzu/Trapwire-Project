using Controllers;
using Models;
using System.Windows.Forms;

namespace Views {

    public class CategoriaCreate : Form {

        public Label lblCategoriaNome;
        public TextBox txtCategoriaNome;
        public Button btCadCategoria;

        public void btCadCategoria_Click(object sender, EventArgs e) {
            if(txtCategoriaNome.Text == ""){
                MessageBox.Show("Preencha o nome");
                return;
            } else {
                CategoriaController.Create(txtCategoriaNome.Text);
                MessageBox.Show("Categoria cadastrada com sucesso.");
                ClearForm();
            }
            CategoriaView categoriaList = Application.OpenForms.OfType<CategoriaView>().FirstOrDefault();
            if (categoriaList != null){
                categoriaList.RefreshList();
            }
            this.Close();
        }

        private void ClearForm() {
            txtCategoriaNome.Clear();
        }

        public CategoriaCreate(){
            Text = "Registrar Categoria";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(251,200);
            
            lblCategoriaNome = new Label();
            lblCategoriaNome.Text = "Nome:";
            lblCategoriaNome.Location = new Point(10, 50);
            lblCategoriaNome.Size = new Size(50, 20);
            
            txtCategoriaNome = new TextBox();
            txtCategoriaNome.Location = new Point(80, 50);
            txtCategoriaNome.Size = new Size(100, 20);

            btCadCategoria = new Button();
            btCadCategoria.Text = "Cadastrar";
            btCadCategoria.Location = new Point(10, 100);
            btCadCategoria.Size = new Size(70, 20);

            Controls.Add(lblCategoriaNome);
            Controls.Add(txtCategoriaNome);
        }
    }
}