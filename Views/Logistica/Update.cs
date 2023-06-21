using Controllers;
using Models;
using System;

namespace Views {

    public class LogisticaUpdate : Form {

        public Label lblnomelogistica;
        public TextBox txtnomelogistica;
        public Label lblproduto;
        public TextBox txtproduto;
        public Label lblidarmazem;
        public TextBox txtidarmazem;
        public Label lbldata;
        public TextBox txtdata;
        public Label lblquantidade;
        public TextBox txtquantidade;
        public Label lbltipo;
        public TextBox txttipo;
        public Button btUpLog;

        public LogisticaModels Logistica;

        private void btUpLog_Click(object sender, EventArgs e) {
            LogisticaModels LogisticaToEdit = this.Logistica;
        }
    }
}