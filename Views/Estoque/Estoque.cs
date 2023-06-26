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

            ListViewItem item = new ListViewItem(row);

        }

    }
}