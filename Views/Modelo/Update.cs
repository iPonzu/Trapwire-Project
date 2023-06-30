using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ModeloUpdate : Form{

        public Label lblNome;
        public TextBox txtNome;
        public Button btUpdateModelo;

        public ModeloModels modelo;

        private void btUpdate_Click(object sender, EventArgs e){
            ModeloModels modeloToUpdate = this.modelo;
            modeloToUpdate.Nome = this.txtNome.Text;
            try{     
                if(modeloToUpdate.Nome ==  ""){
                    MessageBox.Show("Preencha os campos!");
                    return;
                }else{
                    ModeloModels.Update(modeloToUpdate);
                    MessageBox.Show("Modelo modificado.");
                }
                this.Close();
            }catch(Exception ex){
                throw ex;
            }
        }
        public ModeloUpdate(ModeloModels modelo){
            this.modelo = modelo;

            this.Text = "Editar Modelo";
            this.Size = new System.Drawing.Size(234, 191);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new System.Drawing.Point(10,40);
            this.lblNome.Size = new System.Drawing.Size(50,20);

            this.txtNome = new TextBox();
            this.txtNome.Text = modelo.Nome;
            this.txtNome.Location = new System.Drawing.Point(80,40);
            this.txtNome.Size = new System.Drawing.Size(150,20);

            this.btUpdateModelo = new Button();
            this.btUpdateModelo.Text = "Editar";
            this.btUpdateModelo.Location = new System.Drawing.Point(80, 260);
            this.btUpdateModelo.Size = new System.Drawing.Size(150, 35);
            this.btUpdateModelo.Click += new EventHandler(btUpdate_Click);

        
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btUpdateModelo);
        }
    }
}