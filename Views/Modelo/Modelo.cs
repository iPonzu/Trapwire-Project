using Controllers;
using Models;

namespace Views{
    public class ModeloView : Form{
        public enum Option {Upgrade, Delete}

        private void AddListView(ModeloModels modelo){
            string[] row = {
                modelo.Id.ToString(),
                modelo.Nome.ToString(),
            };

            ListViewItem item = new ListViewItem(row);
            // TODO: add list items
        }
        public void RefreshList(){
            // TODO: create list

            List<ModeloModels> list = Controllers.ModeloController.Read();
            foreach (Models.ModeloModels modelo in list){
                AddListView(modelo);
            }
        }
    }
}