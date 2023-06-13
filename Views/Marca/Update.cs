using Controllers;
using Models;
using System;

namespace Views{

    public class MarcaUpdate : Form{

        public Label lblidproduto;
        public TextBox txtidproduto;
        public Label lblmarca;
        public TextBox txtmarca;
        public Label lblcategoria;
        public TextBox txtcategoria;
        public Button btCadtMarca;

        public MarcaModels marca;

        private void btCadt_Click(object sender, EventArgs e){
            MarcaModels marcaToEdit = this.marca;
        }
    }
}
