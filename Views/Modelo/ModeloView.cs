using Models;
using Controllers;        
        
namespace Views{
    public class ListModelo : From{

// namespace Views{
//     public class ListModelo : From{

        public enum option {Upgrade, Delete}


        ListView ListModelo;

        private void AddListView(Models.ModeloModels produto){

        string[]row = {

            modelo.id.ToString(),
            modelo.Modelo.ToString(),/// 
            };

            ListViewItem item = new ListViewItem(row);
            // TODO> Criar lista
        }
        public void RefreshList()
        {
            // TODO> Criar lista

//         ListView ListModelo;

//         private void AddListView(Models.ModeloModels produto){

//             string[]row = {

//                 modelo.id,
//                 modelo.modelo
//             };

//             ListViewItem item = new ListViewItem(row);
//             listProduto.Items.Add(item);
//         }

//         public void RefreshList()
//         {
//             listModelo.Items.Clear();

            List<Models.ModeloModels> list = Controllers.ModeloController.Read();

            foreach (Models.ProdutoModels produto in list)
            {
                AddListView(modelo);
            }
        }
    }
}

//             foreach (Models.ProdutoModels produto in list)
//             {
//                 AddListView(modelo);
//             }
//         }

    
//     }
// }

