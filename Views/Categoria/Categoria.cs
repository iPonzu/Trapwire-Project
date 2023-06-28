using Models;
using Controllers;

namespace Views{
    public class CategoriaView : Form{
        public enum Option {Update, Delete}

        ListView ListCategoria;

        private void AddListView(Models.CategoriaModels categoria){
            string[] row = {
                categoria.Id.ToString(),
                categoria.Nome.ToString()
            };
        }

        public void RefreshList(){
            ListCategoria.Items.Clear();
            List<CategoriaModels> categorias = CategoriaModels.Read();
            foreach (CategoriaModels categoria in categorias){
                AddListView(categoria);
            }
        }

        public CategoriaModels GetSelectedCategoria(Option option){
            if(ListCategoria.SelectedItems.Count == 0){
                int selectedCategoriaId = int.Parse(ListCategoria.SelectedItems[0].Text);
                return Controllers.CategoriaController.ReadById(selectedCategoriaId);
            }else{
                throw new Exception($"Selecione uma categoria para {(option == Option.Update ? "Update" : "Delete")}");
            }
        }

        
        public void btCadCategoria_Click (object sender, EventArgs e){
            var CategoriaCreate = new Views.CategoriaCreate();
            CategoriaCreate.Show();
        }
        
        public void btCategoriaUpdate_Click (object sender, EventArgs e){
            try{
                CategoriaModels categoria = GetSelectedCategoria(Option.Update);
                var CategoriaUpdate = new Views.CategoriaUpdate();
                if(CategoriaUpdate.ShowDialog() == DialogResult.OK){
                   RefreshList();
                   MessageBox.Show("Categoria Atualizada com sucesso"); 
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possível excluir a categoria desejada" + ex.Message);
            }
        }
        
        private void btDelete_Click (object sender, EventArgs e){
            try{
                CategoriaModels categoria = GetSelectedCategoria(Option.Delete);
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir esta categoria agora?" , "Confirmar exlcusão", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes){
                    Controllers.CategoriaController.Delete(categoria.Nome);
                    RefreshList();
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possível excluir a categoria" + ex.Message);
            }
        }

        private void btClose_Click (object sender, EventArgs e){
            this.Close();
        }

        public CategoriaView(){
            this.Text = "Gerenciar Categorias";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;


            ListCategoria = new ListView();
            ListCategoria.Location = new System.Drawing.Point(50, 50);
            ListCategoria.Size = new System.Drawing.Size(700, 400);
            ListCategoria.View = System.Windows.Forms.View.Details;
            ListCategoria.Columns.Add("Id");
            ListCategoria.Columns.Add("Nome");
            ListCategoria.Columns[0].Width = 50;
            ListCategoria.Columns[1].Width = 100;
            ListCategoria.FullRowSelect = true;

            RefreshList();

            Button btCrt = new Button();
            btCrt.Text = "Cadastrar";
            btCrt.Location = new System.Drawing.Point(50, 330);
            btCrt.Size = new System.Drawing.Size(100, 30);
            btCrt.Click += new EventHandler(btCadCategoria_Click);

            Button btUpd = new Button();
            btUpd.Text = "Atualizar";
            btUpd.Location = new System.Drawing.Point(170, 330);
            btUpd.Size = new System.Drawing.Size(100, 30);
            btUpd.Click += new EventHandler(btCategoriaUpdate_Click);

            Button btDelete = new Button();
            btDelete.Text = "Deletar";
            btDelete.Location = new System.Drawing.Point(290, 330);
            btDelete.Size = new System.Drawing.Size(100, 30);
            btDelete.Click += new EventHandler(btDelete_Click);

            Button btClose = new Button();
            btClose.Text = "Fechar";
            btClose.Location = new System.Drawing.Point(450, 330);
            btClose.Size = new System.Drawing.Size(100, 30);
            btClose.Click += new EventHandler(btClose_Click);
            
            Controls.Add(ListCategoria);
            Controls.Add(btCrt);
            Controls.Add(btUpd);
            Controls.Add(btDelete);
            Controls.Add(btClose);
        }
    }
}