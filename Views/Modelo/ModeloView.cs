// using Models;
// using Controllers;

<<<<<<< HEAD
// namespace Views{
//     public class ListModelo : From{
=======
namespace Views{
    public class ListModelo : Form {
>>>>>>> c3b9309cf20c929fcf62d71aa5196aaa3e7de543

//         public enum option {Upgrade, Delete}

<<<<<<< HEAD
//         ListView ListModelo;

//         private void AddListView(Models.ModeloModels produto){
=======
        ListView ListModeloView;

        private void AddListView(Models.ModeloModels modelo){
>>>>>>> c3b9309cf20c929fcf62d71aa5196aaa3e7de543

//             string[]row = {

<<<<<<< HEAD
//                 modelo.id,
//                 modelo.modelo
//             };

//             ListViewItem item = new ListViewItem(row);
//             listProduto.Items.Add(item);
//         }

//         public void RefreshList()
//         {
//             listModelo.Items.Clear();
=======
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
>>>>>>> c3b9309cf20c929fcf62d71aa5196aaa3e7de543

//             List<Models.ModeloModels> list = Controllers.ModeloController.Read();

<<<<<<< HEAD
//             foreach (Models.ProdutoModels produto in list)
//             {
//                 AddListView(modelo);
//             }
//         }
=======
            foreach (Models.ModeloModels modelo in list)
            {
                AddListView(modelo);
            }
        }
>>>>>>> c3b9309cf20c929fcf62d71aa5196aaa3e7de543

    
//     }
// }