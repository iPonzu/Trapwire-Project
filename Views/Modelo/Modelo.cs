using Models;
using Controllers;

namespace Views{
    public class ModeloView : Form{
        public enum Option {Update, Delete}

        ListView ListModelo;

        private void AddListView(Models.ModeloModels modelo){
            string[] row = {
                modelo.Id.ToString(),
                modelo.Nome.ToString()
            };

            ListViewItem item = new ListViewItem(row);
            //TODO: add list
            ListModelo.Items.Add(item);
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