using Models;
using Controllers;

<<<<<<< HEAD
        
        
namespace Views{
    public class ListModelo : From{
=======
// namespace Views{
//     public class ListModelo : From{
>>>>>>> 395ddfe4c1e11b0058fabd747f7fb5d2b86c94c7

        public enum option {Upgrade, Delete}

<<<<<<< HEAD
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
=======
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
>>>>>>> 395ddfe4c1e11b0058fabd747f7fb5d2b86c94c7

            List<Models.ModeloModels> list = Controllers.ModeloController.Read();

<<<<<<< HEAD
            foreach (Models.ProdutoModels produto in list)
            {
                AddListView(modelo);
            }
        }
    }
}
=======
//             foreach (Models.ProdutoModels produto in list)
//             {
//                 AddListView(modelo);
//             }
//         }

    
//     }
// }
>>>>>>> 395ddfe4c1e11b0058fabd747f7fb5d2b86c94c7
