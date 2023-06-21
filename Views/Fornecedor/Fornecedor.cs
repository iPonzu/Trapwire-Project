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
            //create list

            List<FornecedorModels> list = Controllers.FornecedorController.Read();
            foreach(Models.FornecedorModels fornecedor in list){
                AddListView(fornecedor);
            }
        }
    }
}