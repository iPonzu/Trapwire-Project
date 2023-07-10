using Controllers;
using Models;
using System;

namespace Views{

    public class MarcaUpdate : Form{

        public Label lblNome;
        public TextBox txtNome;
        public Button btUpdateMarca;

        public MarcaModels marca;

        private void btUpdate_Click(object sender, EventArgs e){
            MarcaModels marcaToUpdate = this.marca;
            marcaToUpdate.Nome = this.txtNome.Text;
            try{
                if(marcaToUpdate.Nome ==  "" || marcaToUpdate.Id == 0){
                    MessageBox.Show("Preencha os campos!");
                    return;
                }else{
                    MarcaModels.Update(marcaToUpdate);
                    MessageBox.Show("Marca modificado.");
                }
            }catch(Exception ex){
                throw ex;
            }
            this.Close();
        }  

        public MarcaUpdate(MarcaModels marca){
            this.marca = marca;

            this.Text = "Editar Marca";
            this.Size = new System.Drawing.Size(300, 400);
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
            this.txtNome.Text = marca.Nome;
            this.txtNome.Location = new System.Drawing.Point(80,40);
            this.txtNome.Size = new System.Drawing.Size(150,20);

            this.btUpdateMarca = new Button();
            this.btUpdateMarca.Text = "Editar";
            this.btUpdateMarca.Location = new System.Drawing.Point(80, 260);
            this.btUpdateMarca.Size = new System.Drawing.Size(150, 35);
            this.btUpdateMarca.Click += new EventHandler(btUpdate_Click);

        
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btUpdateMarca);
        
        }
    }
}
