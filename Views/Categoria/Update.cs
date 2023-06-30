using Models;
using Controllers;

namespace Views{
    public class CategoriaUpdate : Form{

        public Label lblId;
        public TextBox txtId;
        public Label lblNome;
        public TextBox txtNome;
        public Button btUpdateCategoria;
        public CategoriaModels categoria;

        private void btUpdateCategoria_Click(object sender, EventArgs e){
            CategoriaModels categoriaToUpdate = this.categoria;
            categoriaToUpdate.Id = int.Parse(txtId.Text);
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
        

        
        
        
        
        }
    }
}