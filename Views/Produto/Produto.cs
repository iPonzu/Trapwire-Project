using Models;
using Controllers;

namespace Views{
    public class ProdutoView : Form {
        public enum option {Upgrade, Delete}

        ListView ListProdutoView;

        private void AddListView(Models.ProdutoModels produto){
            string[]row = {
                produto.Id.ToString(),
                produto.Categoriaid.ToString(),
                produto.Modeloid.ToString(),
            };

            ListViewItem item = new ListViewItem(row);
            // TODO> Criar lista
            // listProduto.Items.Add(item);
        }
        public void RefreshList()
        {
            // TODO> Criar lista
            // listProduto.Items.Clear();

            List<Models.ProdutoModels> list = ProdutoController.Read();
            foreach (Models.ProdutoModels produto in list){
                AddListView(produto);
            }
        }
    }
}