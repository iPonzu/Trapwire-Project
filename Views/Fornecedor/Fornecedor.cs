using Models;
using Controllers;

namespace Views{
    public class FornecedorView : Form{
        public enum Option {Update, Delete}

        ListView ListFornecedor;

        private void AddListView(Models.FornecedorModels fornecedor){
            string[] row = {
                fornecedor.Id.ToString(),
                fornecedor.Nome.ToString(),
                fornecedor.NomeSocial.ToString(),
                fornecedor.Endereco.ToString(),
                fornecedor.Cnpj.ToString(),
                fornecedor.Telefone.ToString()
            };

            ListViewItem item = new ListViewItem(row);
            //add list
            ListFornecedor.Items.Add(item);
        }
        public void RefreshList(){
            ListFornecedor.Items.Clear();
            List<FornecedorModels> fornecedores = FornecedorModels.Read();
            foreach(Models.FornecedorModels fornecedor in fornecedores){
                AddListView(fornecedor);
            }
        }
        public FornecedorModels GetSelectedFornecedor(Option option){
            if(ListFornecedor.SelectedItems.Count == 0){
                int selectedFornecedorId = int.Parse(ListFornecedor.SelectedItems[0].Text);
                return Controllers.FornecedorController.ReadById(selectedFornecedorId);
            }else{
                throw new Exception($"Selecione um fornecedor para {(option == Option.Update ? "Update" : "Delete")}");
            }
        }
        public void btCadFornecedor_Click(object sender, EventArgs e){
            var FornecedorCreate = new Views.FornecedorCreate();
            FornecedorCreate.Show();
        }
        public void btFornecedorUpdate_Click (object sender, EventArgs e){
            try{
                FornecedorModels fornecedor = GetSelectedFornecedor(Option.Update);
                var FornecedorUpdate = new Views.FornecedorUpdate();
                if(FornecedorUpdate.ShowDialog() == DialogResult.OK){
                   RefreshList();
                   MessageBox.Show("Fornecedor atualizado com sucesso"); 
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possível excluir o fornecedor desejado" + ex.Message);
            }
        }
        private void btDelete_Click(object sender, EventArgs e){
            try{
                FornecedorModels fornecedor = GetSelectedFornecedor(Option.Delete);
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir este fornecedor?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes){
                    Controllers.FornecedorController.Delete(fornecedor.Nome);
                }
            }catch(Exception ex){
                MessageBox.Show("Não foi possível excluir o fornecedor" + ex.Message);
            }
        }
        private void btClose_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}