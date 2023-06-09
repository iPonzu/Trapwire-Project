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
            ListViewItem item = new ListViewItem(row);
            ListCategoria.Items.Add(item);
        }

        public void RefreshList(){
            ListCategoria.Items.Clear();
            List<CategoriaModels> categorias = CategoriaModels.Read();
            foreach (CategoriaModels categoria in categorias){
                AddListView(categoria);
            }
        }

        public CategoriaModels GetSelectedCategoria(Option option){
            if(ListCategoria.SelectedItems.Count > 0){
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
        
        private void btCategoriaUpdate_Click(object sender, EventArgs e){
            CategoriaModels categoria = GetSelectedCategoria(Option.Update);
            DialogResult result = MessageBox.Show("Tem certeza que quer atualizar esta categoria agora?" , "Confirmar atualização", MessageBoxButtons.YesNo);
            if(categoria != null){
                var CategoriaUpdate = new Views.CategoriaUpdate(categoria);
                if(CategoriaUpdate.ShowDialog() == DialogResult.OK){
                    RefreshList();
                    MessageBox.Show("Categoria atualizada.");
                }
            }
            RefreshList();
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
            this.Size = new System.Drawing.Size(800, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;


            ListCategoria = new ListView();
            ListCategoria.Size = new System.Drawing.Size(700, 400);
            ListCategoria.Location = new System.Drawing.Point(50, 50);
            ListCategoria.View = System.Windows.Forms.View.Details;
            ListCategoria.FullRowSelect = true;
            ListCategoria.Columns.Add("Id", -2, HorizontalAlignment.Center);
            ListCategoria.Columns.Add("Nome", -2, HorizontalAlignment.Center);
            ListCategoria.Columns[0].Width = 50;
            ListCategoria.Columns[1].Width = 100;

            RefreshList();

            Button btCrt = new Button();
            btCrt.Text = "Cadastrar";
            btCrt.Location = new System.Drawing.Point(50, 550);
            btCrt.Click += new EventHandler(btCadCategoria_Click);

            Button btUpd = new Button();
            btUpd.Text = "Atualizar";
            btUpd.Location = new System.Drawing.Point(150, 550);
            btUpd.Click += new EventHandler(btCategoriaUpdate_Click);

            Button btDelete = new Button();
            btDelete.Text = "Deletar";
            btDelete.Location = new System.Drawing.Point(250, 550);
            btDelete.Click += new EventHandler(btDelete_Click);

            Button btClose = new Button();
            btClose.Text = "Fechar";
            btClose.Location = new System.Drawing.Point(350, 550);
            btClose.Click += new EventHandler(btClose_Click);

            
            Controls.Add(ListCategoria);
            Controls.Add(btCrt);
            Controls.Add(btUpd);
            Controls.Add(btDelete);
            Controls.Add(btClose);
        }
    }
}