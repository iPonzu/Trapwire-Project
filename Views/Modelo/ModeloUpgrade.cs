using Controllers;
using Models;
using System;

namespace Views{

    public class ModeloUpgrade : Form{

        public Label lblid;
        public TextBox txtid;
        public Label lblmodelo;
        public TextBox txtmodelo;
        public Button btCadt;

        public ModeloModels modelo;

        private void btnCadt_Click(object sender, EventArgs e){
            ModeloModels modeloToEdit = this.modelo;
        }
    }
}