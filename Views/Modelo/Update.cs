using Controllers;
using Models;
using System;

namespace Views{

    public class ModeloUpdate : Form{

        public Label lblidmodelo;
        public TextBox txtidmodelo;
        public Label lblmodelo;
        public TextBox txtmodelo;
        public Button btCadtModelo;

        public ModeloModels modelo;

        private void btCadt_Click(object sender, EventArgs e){
            ModeloModels modeloToEdit = this.modelo;
        }
    }
}