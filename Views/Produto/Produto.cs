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
            Text = "Produtos";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(534, 383);
        
            ListProduto = new ListView();

        
        }
    }
}