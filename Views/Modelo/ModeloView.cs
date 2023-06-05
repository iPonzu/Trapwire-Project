using Models;
using Controllers;

namespace Views{
    public class ListModelo : Form {

        public enum option {Upgrade, Delete}

        ListView ListModeloView;

        private void AddListView(Models.ModeloModels modelo){

            string[]row = {

                modelo.Id.ToString(),
                modelo.Modelo
            };

            ListViewItem item = new ListViewItem(row);
            // TODO: Criar lista
            // listProduto.Items.Add(item);
        }

        public void RefreshList()
        {
            // TODO: Criar lista
            // listModelo.Items.Clear();

            List<Models.ModeloModels> list = Controllers.ModeloController.Read();

            foreach (Models.ModeloModels modelo in list)
            {
                AddListView(modelo);
            }
        }

    
    }
}