using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ModeloCreate : Form{
        
        public Label lblid;
        public TextBox txtid;
        public Label lblmodelo;
        public TextBox txtmodelo;
        public Button btCadt;

        // public void btcadt_Click()
        // {
        //     if(txtid.Text == "" || txtmodelo.Text == "" ){
        //         MessageBox.Show("Criando Modelo");
        //         return;
        //     }else{
        //         Models.ModeloModels modelo = new ModeloModels(
        //             txtmodelo.Text
        //         );

        //         ModeloController modeloController = new ModeloController();

        //         MessageBox.Show("Modelo cadasdtrado!");
        //         // clearform();
        //     }

        //     // List<ModeloModels> ModeloList = ModeloController.Read();
        //     // if(ModeloList == null)
        //     // {
        //     //     ModeloList.refreshList();
        //     // }
        //     // this.Close();
        // }
        // private void clearform()
        // {
        //     txtid.Clear();
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

            this.lblid = new Label();
            this.lblid.Text = "Id:";
            this.lblid.Location = new Point(10, 50); // Horizontal, Vertical
            this.lblid.Size = new Size(50, 20); // Largura, Altura

            this.txtid = new TextBox();  
            this.txtid.Location = new Point(80, 40);
            this.txtid.Size = new Size(150, 20);

            this.lblmodelo = new Label();
            this.lblmodelo.Text = "Modelo:";
            this.lblid.Location = new Point(10, 70);
            this.lblid.Size = new Size(50, 20);

            this.txtmodelo = new TextBox();
            this.txtmodelo.Location = new Point(80, 70);
            this.txtmodelo.Size = new Size(150, 20);

            this.btCadt = new Button();
            this.btCadt.Text = "Cadastrar";
            this.btCadt.Location = new Point(10, 130);
            this.btCadt.Size = new Size(70, 20);


            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.btCadt);
        }
    }
}