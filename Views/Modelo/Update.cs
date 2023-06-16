using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ModeloUpdate : Form{

        public Label lblid;
        public TextBox txtid;
        public Label lblmodelo;
        public TextBox txtNome;
        public Button btUpdateModelo;

        public ModeloModels modelo;

        private void btUpdate_Click(object sender, EventArgs e){
            ModeloModels modeloToUpdate = this.modelo;
            modeloToUpdate.Id = Convert.ToInt32(this.txtid.Text);
            modeloToUpdate.Nome = this.txtNome.Text;

            if(modeloToUpdate.Nome ==  "" || modeloToUpdate.Id == 0){
                MessageBox.Show("Preencha os campos!");
                return;
            }else{
                ModeloController.Update(modeloToUpdate);
                MessageBox.Show("Modelo modificado.");
            }
            
        }
    }
}