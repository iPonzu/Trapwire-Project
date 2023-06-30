using Models;
using Controllers;

namespace Views{
    public class ProdutoView : Form {
        public enum Option {Update, Delete}

        ListView ListProduto;

        private void AddListView(Models.ProdutoModels produto){
            string[]row = {
                produto.Id.ToString(),
                produto.Categoriaid.ToString(),
                produto.Modeloid.ToString(),
            };  
        }
        public void RefreshList(){
            ListProduto.Items.Clear();
            List<ProdutoModels> produtos = ProdutoModels.Read();
            foreach (ProdutoModels produto in produtos){
                AddListView(produto);
            }
        }

        public ProdutoModels GetSelectedProduto(Option option){
            if(ListProduto.SelectedItems.Count > 0){
                int selectedProdutoId = int.Parse(ListProduto.SelectedItems[0].Text);
                return Controllers.ProdutoController.ReadById(selectedProdutoId);
            }else{
                throw new Exception($"Selecione um produto para {(option == Option.Update ? "Update" : "Delete")}");
            }
        }

        
        public void btCadProduto_Click (object sender, EventArgs e){
            var ProdutoCreate = new Views.ProdutoCreate();
            ProdutoCreate.Show();
        }
        
        public void btProdutoUpdate_Click (object sender, EventArgs e){
            try{
                ProdutoModels produto = GetSelectedProduto(Option.Update);
                RefreshList();
                var ProdutoUpdate = new Views.ProdutoUpdate(produto);
                if(ProdutoUpdate.ShowDialog() == DialogResult.OK){
                   RefreshList();
                   MessageBox.Show("Produto Atualizado com sucesso"); 
                }
            } catch (Exception err) {
                MessageBox.Show("Não foi possível excluir o produto desejado" + err.Message);
            }
        }
        
        private void btDelete_Click (object sender, EventArgs e){
            try{
                ProdutoModels Produto = GetSelectedProduto(Option.Delete);
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir este produto agora?" , "Confirmar exlcusão", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes){
                    Controllers.ProdutoController.Delete(Convert.ToString(Produto.Id));
                    RefreshList();
                }
            } catch (Exception err) {
                MessageBox.Show("Não foi possível excluir o produto" + err.Message);
            }
        }

        private void btClose_Click (object sender, EventArgs e){
            this.Close();
        }

        public ProdutoView(){
           this.Text = "Produtos";
            this.Size = new Size(800, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            ListProduto = new ListView();
            ListProduto.Size = new Size(680, 260);
            ListProduto.Location = new Point(50 ,50);
            ListProduto.View = View.Details;
            ListProduto.Columns.Add("ID");
            ListProduto.Columns.Add("Nome");
            ListProduto.Columns.Add("Modelo");
            ListProduto.Columns.Add("Categoria");
            ListProduto.FullRowSelect = true;
            this.Controls.Add(ListProduto);

            RefreshList();

            Button btCad = new Button();
            btCad.Text = "Cadastrar";
            btCad.Size = new Size(100, 30);
            btCad.Location = new Point(50, 330);
            btCad.Click += new EventHandler(btCadProduto_Click);
            this.Controls.Add(btCad);

            Button btUpdate = new Button();
            btUpdate.Text = "Editar";
            btUpdate.Size = new Size(100, 30);
            btUpdate.Location = new Point(170, 330);
            btUpdate.Click += new EventHandler(btProdutoUpdate_Click);
            this.Controls.Add(btUpdate);

            Button btDelete = new Button();
            btDelete.Text = "Excluir";
            btDelete.Size = new Size(100, 30);
            btDelete.Location = new Point(290, 330);
            btDelete.Click += new EventHandler(btDelete_Click);
            this.Controls.Add(btDelete);

            Button btClose = new Button();
            btClose.Text = "Voltar";
            btClose.Size = new Size(100, 30);
            btClose.Location = new Point(450, 330);
            btClose.Click += new EventHandler(btClose_Click);
            this.Controls.Add(btClose);

        
        }
    }
}