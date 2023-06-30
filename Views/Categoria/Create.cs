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

            this.Text = "Registrar Categoria";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(251,200);
            
            this.lblCategoriaNome = new Label();
            this.lblCategoriaNome.Text = "Nome:";
            this.lblCategoriaNome.Location = new Point(10, 50);
            this.lblCategoriaNome.Size = new Size(50, 20);
            
            this.txtCategoriaNome = new TextBox();
            this.txtCategoriaNome.Location = new Point(80, 50);
            this.txtCategoriaNome.Size = new Size(100, 20);

            this.btCadCategoria = new Button();
            this.btCadCategoria.Text = "Cadastrar";
            this.btCadCategoria.Location = new Point(10, 100);
            this.btCadCategoria.Size = new Size(70, 20);

            Controls.Add(lblCategoriaNome);
            Controls.Add(txtCategoriaNome);
        }
    }
}