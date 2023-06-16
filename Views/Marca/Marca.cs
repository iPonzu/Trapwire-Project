using Controllers;
using Models;

namespace Views{
    public class MarcaView : Form{
        public enum Option {Upgrade, Delete}

        ListView marca;

        private void AddListView(MarcaModels modelo){
            string[] row = {
                modelo.Id.ToString(),
                modelo.Nome.ToString(),
            };

            ListViewItem item = new ListViewItem(row);
            // TODO> add list items
        }
        public void RefreshList(){
            // TODO> create list

            List<MarcaModels> list = Controllers.MarcaController.Read();
            foreach (Models.MarcaModels marca in list){
                AddListView(marca);
            }
        }
    }
}