using Controllers;
using Models;
using System;

namespace Views{

    public class Update : Form{

        public Label lblid;
        public TextBox txtid;
        public Label lblmarca;
        public TextBox txtmarca;
        public Label lblcategoria;
        public TextBox txtcategoria;
        public Button btCadt;

        public Produto produto;

        private void btnCadt_Click(object sender, EventArgs e){
            Produto produtoToEdit = this.produto;
        }
    }
}
