using Models;
using Controllers;

namespace Views{
    public class ListProduto : Form {

        public enum option {Upgrade, Delete}

        ListView ListProdutoView;

        private void AddListView(Models.ProdutoModels produto){

            string[]row = {

                produto.Id.ToString(),
                produto.Marca,
                produto.Categoriaid.ToString()
            };

            ListViewItem item = new ListViewItem(row);
            // TODO> Criar lista
            // listProduto.Items.Add(item);
        }

        public void RefreshList()
        {
            // TODO> Criar lista
            // listProduto.Items.Clear();

            List<Models.ProdutoModels> list = Controllers.ProdutoController.Read();

            foreach (Models.ProdutoModels produto in list)
            {
                AddListView(produto);
            }
        }

    
    }
}