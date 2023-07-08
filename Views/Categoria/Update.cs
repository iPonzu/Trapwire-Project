using Models;
using Controllers;

namespace Views{
    public class CategoriaUpdate : Form{

        public Label lblNome;
        public TextBox txtNome;
        public Button btUpdateCategoria;
        public CategoriaModels categoria;

        private void btUpdateCategoria_Click(object sender, EventArgs e){
            CategoriaModels categoriaToUpdate = this.categoria;
            // categoriaToUpdate.Id = int.Parse(txtId.Text);
            categoriaToUpdate.Nome = Convert.ToString(this.txtNome.Text);
            
            try{
                if(categoriaToUpdate.Id == 0 || categoriaToUpdate.Nome == null){
                    MessageBox.Show("Preencha os campos");
                    return;
                }else{
                    CategoriaModels.Update(categoriaToUpdate);
                    MessageBox.Show("Categoria modificada");
                }
                this.Close();
            }catch(Exception ex){
                throw ex;
            }
        }
    
        public CategoriaUpdate(CategoriaModels categoria) {
            this.categoria = categoria;
        
            this.Text = "Atualizar Categoria";
            this.Size = new System.Drawing.Size(280, 360);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;   
            this.ShowInTaskbar = false;

<<<<<<< HEAD
            // lblId = new Label();
            // lblId.Text = "Id: ";
            // lblId.Size = new Size(50, 20);
            // lblId.Location = new Point(10, 40);
            // this.Controls.Add(lblId);

            // txtId = new TextBox();
            // txtId.Location = new Point(80, 40);
            // txtId.Size = new Size(150, 20);
            // this.Controls.Add(txtId);
=======
            this.lblId = new Label();
            this.lblId.Text = "Id";
            this.lblId.Location = new System.Drawing.Point(10, 40);
            this.lblId.Size = new System.Drawing.Size(50, 20);
            this.Controls.Add(lblId);

            this.txtId = new TextBox();
            this.txtId.Location = new System.Drawing.Point(80, 40);
            this.txtId.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(txtId);
>>>>>>> cc5306b756261fa8a26ac60185295b43a92bfd46

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new System.Drawing.Point(10, 70);
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.Controls.Add(lblNome);

            this.txtNome = new TextBox();
            this.txtNome.Location = new System.Drawing.Point(80, 70);
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(txtNome);

            this.btUpdateCategoria = new Button();
            this.btUpdateCategoria.Text = "Atualizar";
            this.btUpdateCategoria.Location = new System.Drawing.Point(80, 260);
            this.btUpdateCategoria.Size = new System.Drawing.Size(150, 35);
            this.btUpdateCategoria.Click += new EventHandler(btUpdateCategoria_Click);

            this.Controls.Add(lblId);
            this.Controls.Add(txtId);
            this.Controls.Add(lblNome);
            this.Controls.Add(txtNome);
            this.Controls.Add(btUpdateCategoria);
        }
    }
}