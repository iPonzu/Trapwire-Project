using Models;
using Controllers;

namespace Views{
    public class CategoriaUpdate : Form{

        public Label lblid;
        public TextBox txtid;
        public Label lblnome;
        public TextBox txtnome;
        public Button btUpCategoria;

        public CategoriaModels categoria;

        private void btUpCategoria_Click(object sender, EventArgs e){
            CategoriaModels categoria = this.categoria;
        }
    }
}