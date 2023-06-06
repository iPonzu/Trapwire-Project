using Models;
using Controllers;
        
        
namespace Views{
    public class ListModelo : From{

        public enum option {Upgrade, Delete}


        ListView ListModelo;

        private void AddListView(Models.ModeloModels produto){

            string[]row = {

            modelo.id.ToString(),
            modelo.Modelo 
            };

            ListViewItem item = new ListViewItem(row);
                // TODO> Criar lista
        }
        public void RefreshList()
        {
                // TODO> Criar lista

            List<Models.ModeloModels> list = Controllers.ModeloController.Read();


            foreach (Models.ProdutoModels produto in list)
            {
                AddListView(modelo);
            }
        }
    }
}