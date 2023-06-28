using Models;
using Controllers;

namespace Views{
    public class CategoriaUpdate : Form{

        public Label lblid;
        public TextBox txtid;
        public Label lblNome;
        public TextBox txtNome;
        public Button btUpdateCategoria;
        public CategoriaModels categoria;

        private void btUpdateCategoria_Click(object sender, EventArgs e){
            CategoriaModels categoriaToUpdate = this.categoria;
            categoriaToUpdate.Nome = Convert.ToString(this.txtNome.Text);
            Controllers.CategoriaController.Update(categoriaToUpdate);
            
            ListCategoria categoriaList = Application.OpenForms.OfType<ListCategoria>().FirstOrDefault();
        
            if(categoriaList != null){
                categoriaList.RefreshList();
            }
            this.Close();
        }

        public CategoriaUpdate() {
            this.categoria = categoria;
        }
    }
}