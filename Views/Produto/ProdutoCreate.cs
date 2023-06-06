// /* testing space */


// using Models;
// using Controllers;
// using System.Windows.Forms;

// namespace Views{
//     public class test : Form{
//         public enum Option { Upgrade, Delete }

//         private void AddListView(ModeloModels modelo){
//             string[] row = {
//                 modelo.Id.ToString(),
//                 modelo.Nome.ToString(),
//             };

//             ListViewItem item = new ListViewItem(row);
//             // TODO: Adicionar item à lista
//         }

//         public void RefreshList()
//         {
//             // TODO: Criar lista

//             List<ModeloModels> list = ModeloController.Read();

//             foreach (ModeloModels modelo in list) //modelo models (declarar modelo) in (lista)
//             {
//                 AddListView(modelo);
//             }
//         }
//     }
// }

using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ProdutoCreate : Form {
        
        public Label lblid;
        public TextBox txtid;
        public Label lblmarca;
        public TextBox txtmarca;
        public Label lblmodelo;
        public TextBox txtmodelo;
        public Label lblcategoria;
        public TextBox txtcategoria;
        public Button btCadt;

        public ProdutoCreate()
        {
            Text = "Registrar Produto";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(280, 360);

        // id - lbl
            lblid = new Label();
            lblid.Text = "ID:";
            lblid.Location = new Point(10, 20); // Horizontal, Vertical
            lblid.Size = new Size(20, 20); // Largura, Altura
        // id - txt
            txtid = new TextBox();  
            txtid.Location = new Point(80, 20);
            txtid.Size = new Size(50, 30);

            lblmarca = new Label();
            lblmarca.Text = "Marca:";
            lblmarca.Location = new Point(10, 50);
            lblmarca.Size = new Size(50, 20);

            txtmarca = new TextBox();
            txtmarca.Location = new Point(80, 50);
            txtmarca.Size = new Size(100, 20);

            lblmodelo = new Label();
            lblmodelo.Text = "Modelo:";
            lblmodelo.Location = new Point(10, 80);
            lblmodelo.Size = new Size(50, 20);

            txtmodelo = new TextBox();
            txtmodelo.Location = new Point(80, 80);
            txtmodelo.Size = new Size(80, 20);

            lblcategoria = new Label();
            lblcategoria.Text = "Categoria:";
            lblcategoria.Location = new Point(10, 110);
            lblcategoria.Size = new Size(70, 20);

            txtcategoria = new TextBox();
            txtcategoria.Location = new Point(80, 110);
            txtcategoria.Size = new Size(150, 20);

            /* buttons */
            btCadt = new Button();
            btCadt.Text = "Cadastrar";
            btCadt.Location = new Point(10, 150);
            btCadt.Size = new Size(70, 20);




            Controls.Add(lblid);
            Controls.Add(txtid);
            Controls.Add(lblmarca);
            Controls.Add(txtmarca);
            Controls.Add(lblcategoria);
            Controls.Add(txtcategoria);
            Controls.Add(lblmodelo);
            Controls.Add(txtmodelo);
            Controls.Add(btCadt);
        }
    }   
}
