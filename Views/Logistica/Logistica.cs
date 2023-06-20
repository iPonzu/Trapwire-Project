using Models;
using Controllers;

namespace Views{
    public class LogisticaView : Form{
        public enum Option {Upgrade, Delete}

        ListView ListLogistica;

        private void AddListView (Models.LogisticaModels logistica){
            string [] row = {
                logistica.Data.ToString(),
                logistica.Quantidade.ToString(),
                logistica.Produtoid.ToString(),
                logistica.Estoqueid.ToString()
            };

            ListViewItem item = new ListViewItem(row);
            // todo> criar lista
            //listView.Items.Add
        }
        public void RefreshList()
        {
            //todo> criar lista
            // clear

            List<Models.LogisticaModels> list = LogisticaController.Read();
            foreach (Models.LogisticaModels logistica in list){
                AddListView(logistica);
            }
        }
    }
}