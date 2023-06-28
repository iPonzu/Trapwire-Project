using Models;
using Controllers;

namespace Views{
    public class EstoqueView : Form{
        public enum Option {Update, Delete}

        ListView ListEstoque;

        private void AddListView(Models.EstoqueModels estoque){
            string[] row = {
                estoque.Id.ToString(),
                estoque.Nome.ToString(),
                estoque.Endereco.ToString(),
            };
        }
        public void RefreshList(){
            ListEstoque.Items.Clear();
            List<EstoqueModels> estoques = EstoqueModels.Read();
            foreach (EstoqueModels estoque in estoques){
                AddListView(estoque);
            }
        }
        public EstoqueModels GetSelectedEstoque(Option option){
            if(ListEstoque.SelectedItems.Count == 0){
                int selectedEstoqueId = int.Parse(ListEstoque.SelectedItems[0].Text);
                return Controllers.EstoqueController.ReadById(selectedEstoqueId);
            }else{
                throw new Exception($"Selecione um estoque para {(option == Option.Update ? "Update" : "Delete")}");
            }
        }
        public void btCadEstoque_Click(object sender, EventArgs e){
            var EstoqueCreate = new Views.EstoqueCreate();
            EstoqueCreate.Show();
        }
        public void btEstoqueUpdate_Click(object sender, EventArgs e){
            try{
                EstoqueModels estoque = GetSelectedEstoque(Option.Update);
                var EstoqueUpdate = new Views.EstoqueUpdate();
                if(EstoqueUpdate.ShowDialog() == DialogResult.OK){
                    RefreshList();
                    MessageBox.Show("Estoque atualizado.");
                }
            }
            catch (Exception ex){
                MessageBox.Show("Não foi possível atualizar ou excluir o estoque" + ex.Message);
            }
        }
        private void btDelete_Click(object sender, EventArgs e){
            try{
                EstoqueModels estoque = GetSelectedEstoque(Option.Delete);
                DialogResult result = MessageBox.Show("Tem certeza de que quer excluir este estoque agora?" , "Confirmar exclusão", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes){
                    Controllers.EstoqueController.Delete(estoque.Nome);
                }
            }catch (Exception ex){
                MessageBox.Show("Não foi possível excluir este estoque" + ex.Message);
            }
        }
        private void btClose_Click(object sender, EventArgs e){
            this.Close();
        }

        public EstoqueView(){

        }
    }
}