using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ModeloCreate : Form{
        
        public Label lblidmodelo;
        public TextBox txtidmodelo;
        public Label lblmodelo;
        public TextBox txtmodelo;
        public Button btModelo;

        // public void btModelo_Click()
        // {
        //     if(txtidmodelo.Text == "" || txtmodelo.Text == "" ){
        //         MessageBox.Show("Criando Modelo");
        //         return;
        //     }else{
        //         Models.Modelo modelo = new Modelo(
        //             txtmodelo.Text
        //         );

        //         ModeloController modeloController = new ModeloController();

        //         MessageBox.Show("Modelo cadasdtrado!");
        //         // clearform();
        //     }

        //     // List<Modelo> ModeloList = ModeloController.Read();
        //     // if(ModeloList == null)
        //     // {
        //     //     ModeloList.refreshList();
        //     // }
        //     // this.Close();
        // }
        // private void clearform()
        // {
        //     txtidmodelo.Clear();
        //     txtmodelo.Clear();
        // }

        public ModeloCreate()
        {
            this.Text = "Registrar Modelo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(280, 360);

            this.lblidmodelo = new Label();
            this.lblidmodelo.Text = "Id:";
            this.lblidmodelo.Location = new Point(10, 50); // Horizontal, Vertical
            this.lblidmodelo.Size = new Size(50, 20); // Largura, Altura

            this.txtidmodelo = new TextBox();  
            this.txtidmodelo.Location = new Point(80, 40);
            this.txtidmodelo.Size = new Size(150, 20);

            this.lblmodelo = new Label();
            this.lblmodelo.Text = "Modelo:";
            this.lblidmodelo.Location = new Point(10, 70);
            this.lblidmodelo.Size = new Size(50, 20);

            this.txtmodelo = new TextBox();
            this.txtmodelo.Location = new Point(80, 70);
            this.txtmodelo.Size = new Size(150, 20);

            this.btModelo = new Button();
            this.btModelo.Text = "Cadastrar";
            this.btModelo.Location = new Point(10, 130);
            this.btModelo.Size = new Size(70, 20);


            this.Controls.Add(this.lblidmodelo);
            this.Controls.Add(this.txtidmodelo);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.btModelo);
        }
    }
}