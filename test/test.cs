// // // /* testing only */
// // // using Controllers;
// // // using Models;

// // // namespace Views{
// // //     public class MarcaView : Form{
// // //         public enum Option {Upgrade, Delete}

// // //         private void AddListView(MarcaModels modelo){
// // //             string[] row = {
// // //                 modelo.Id.ToString(),
// // //                 modelo.Nome.ToString(),
// // //             };

// // //             ListViewItem item = new ListViewItem(row);
// // //             // TODO> add list items
// // //         }
// // //         public void RefreshList(){
// // //             // TODO> create list

// // //             List<MarcaModels> list = Controllers.MarcaController.Read();
// // //             foreach (Models.MarcaModels marca in list){
// // //                 AddListView(marca);
// // //             }
// // //         }
// // //     }
// // // }

// // using Controllers;
// // using Models;
// // using System.Windows.Forms;

// // namespace Views{
// //     public class test : Form{
// //         public Label lblidmodelo;
// //         public TextBox txtidmodelo;
// //         public Label lblmarcanome;
// //         public TextBox txtmarcanome;
// //         public Button btMarcaCreate;

// //         public test()
// //         {
// //             Text = "Registrar Marca";
// //             StartPosition = FormStartPosition.CenterScreen;
// //             FormBorderStyle = FormBorderStyle.FixedSingle;
// //             MaximizeBox = false;
// //             MinimizeBox = false;
// //             ShowIcon = false;
// //             ShowInTaskbar = false;
// //             Size = new System.Drawing.Size(251,200);

// //             lblidmodelo = new Label();
// //             lblidmodelo.Text = "ID:";
// //             lblidmodelo.Location = new Point(10, 20);
// //             lblidmodelo.Size = new Size(20, 20);   

// //             txtidmodelo = new TextBox();  
// //             txtidmodelo.Location = new Point(80, 20);
// //             txtidmodelo.Size = new Size(50, 30);

// //             lblmarcanome = new Label();
// //             lblmarcanome.Text = "Nome:";
// //             lblmarcanome.Location = new Point(10, 50);
// //             lblmarcanome.Size = new Size(50, 20);
            
// //             txtmarcanome = new TextBox();
// //             txtmarcanome.Location = new Point(80, 50);
// //             txtmarcanome.Size = new Size(100, 20);

// //             btMarcaCreate = new Button();
// //             btMarcaCreate.Text = "Cadastrar";
// //             btMarcaCreate.Location = new Point(10, 100);
// //             btMarcaCreate.Size = new Size(70, 20);

// //             Controls.Add(lblidmodelo);
// //             Controls.Add(txtidmodelo);
// //             Controls.Add(lblmarcanome);           
// //             Controls.Add(txtmarcanome);
// //             Controls.Add(btMarcaCreate);
            

// //         }
// //     }
// // }
// using Controllers;
// using Models;

// namespace Views{
//     public class test : Form{
//         public enum Option {Upgrade, Delete}

//         ListView listModelo;

//         private void AddListView(Models.ModeloModels modelo){
//             string[] row = {
//                 modelo.Id.ToString(),
//                 modelo.Nome.ToString(),
//                 modelo.marcaid.ToString(),
//             };

//             ListViewItem item = new ListViewItem(row);
//             //TODO: add list
//             listModelo.Items.Add(item);
//         }
//         public void RefreshList(){
//             // TODO: create list

//             List<ModeloModels> list = Controllers.ModeloController.Read();
//             foreach (Models.ModeloModels modelo in list){
//                 AddListView(modelo);
//             }
//         }
//     }
// }