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
            this.Size = new Size(300, 360);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;   
            this.ShowInTaskbar = false;

            // lblId = new Label();
            // lblId.Text = "Id: ";
            // lblId.Size = new Size(50, 20);
            // lblId.Location = new Point(10, 40);
            // this.Controls.Add(lblId);

            // txtId = new TextBox();
            // txtId.Location = new Point(80, 40);
            // txtId.Size = new Size(150, 20);
            // this.Controls.Add(txtId);

            lblNome = new Label();
            lblNome.Text = "Nome: ";
            lblNome.Size = new Size(50, 20);
            lblNome.Location = new Point(10, 80);
            this.Controls.Add(lblNome);

            txtNome = new TextBox();
            txtNome.Location = new Point(80, 80);
            txtNome.Size = new Size(150, 20);
            this.Controls.Add(txtNome);

            btUpdateCategoria = new Button();
            btUpdateCategoria.Text = "Atualizar";
            btUpdateCategoria.Size = new Size(150, 25);
            btUpdateCategoria.Location = new Point(80, 260);
            btUpdateCategoria.Click += new EventHandler(btUpdateCategoria_Click);
            this.Controls.Add(btUpdateCategoria);
        }
    }
}