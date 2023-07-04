using Models;
using Controllers;
using System.Windows.Forms;

namespace Views{
    public class FornecedorCreate : Form{
        public Label lblidfornecedor;
        public TextBox txtidfornecedor;
        public Label lblNomefornecedor;
        public TextBox txtNomefornecedor;
        public Label lblNomeSocial;
        public TextBox txtNomeSocial;
        public Label lblcnpj;
        public TextBox txtcnpj;
        public Label lblEndereco;
        public TextBox txtEndereco;
        public Label lblTelefone;
        public TextBox txtTelefone;
        public Button btCadFornecedor;


        public void btCadFornecedor_Click(object sender, EventArgs e){
            if(txtNomefornecedor.Text == "" || txtNomeSocial.Text == "" || txtEndereco.Text == "" || txtTelefone.Text == "" || txtcnpj.Text == ""){
                MessageBox.Show("Preencha os campos!");
                return;
            }else{
                FornecedorController.Create(txtNomefornecedor.Text,txtNomeSocial.Text, txtEndereco.Text, txtTelefone.Text, txtcnpj.Text);
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                ClearForm();
            }
            FornecedorView fornecedorList = Application.OpenForms.OfType<FornecedorView>().FirstOrDefault();
            if(fornecedorList != null){
                fornecedorList.RefreshList();
            }
            this.Close();
        } 

        private void ClearForm()
        {
            txtNomefornecedor.Clear();
            txtNomeSocial.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtcnpj.Clear();
        }

        public FornecedorCreate(){
            this.Text = "Registrar Fornecedor";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(344,383);

            this.lblidfornecedor = new Label();
            this.lblidfornecedor.Text = "Fornecedor:";
            this.lblidfornecedor.Location = new System.Drawing.Point(10, 40);
            this.lblidfornecedor.Size = new System.Drawing.Size(70, 20);

            this.txtidfornecedor = new TextBox();
            this.txtidfornecedor.Location = new System.Drawing.Point(90, 40);
            this.txtidfornecedor.Size = new System.Drawing.Size(150, 20);

            this.lblNomefornecedor = new Label();
            this.lblNomefornecedor.Text = "Nome:";
            this.lblNomefornecedor.Location = new System.Drawing.Point(10, 70);
            this.lblNomefornecedor.Size = new System.Drawing.Size(50, 20);

            this.txtNomefornecedor = new TextBox();
            this.txtNomefornecedor.Location = new System.Drawing.Point(90, 70);
            this.txtNomefornecedor.Size = new System.Drawing.Size(150, 20);

            this.lblNomeSocial = new Label();
            this.lblNomeSocial.Text = "Nome Social:";
            this.lblNomeSocial.Location = new System.Drawing.Point(10, 100);
            this.lblNomeSocial.Size = new System.Drawing.Size(50, 20);

            this.txtNomeSocial = new TextBox();
            this.txtNomeSocial.Location = new System.Drawing.Point(90, 100);
            this.txtNomeSocial.Size = new System.Drawing.Size(150, 20);

            this.lblcnpj = new Label();
            this.lblcnpj.Text = "CNPJ:";
            this.lblcnpj.Location = new System.Drawing.Point(10, 130);
            this.lblcnpj.Size = new System.Drawing.Size(50, 20);

            this.txtcnpj = new TextBox();
            this.txtcnpj.Location = new System.Drawing.Point(90, 130);
            this.txtcnpj.Size = new System.Drawing.Size(150, 20);

            this.lblEndereco = new Label();
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.Location = new System.Drawing.Point(10, 160);
            this.lblEndereco.Size = new System.Drawing.Size(50, 20);

            this.txtEndereco = new TextBox();
            this.txtEndereco.Location = new System.Drawing.Point(90, 160);
            this.txtEndereco.Size = new System.Drawing.Size(150, 23);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.Location = new System.Drawing.Point(10, 190);
            this.lblTelefone.Size = new System.Drawing.Size(50, 20);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new System.Drawing.Point(90, 190);
            this.txtTelefone.Size = new System.Drawing.Size(150, 20);

            this.btCadFornecedor = new Button();
            this.btCadFornecedor.Text = "Cadastrar";
            this.btCadFornecedor.Location = new System.Drawing.Point(90, 240);
            this.btCadFornecedor.Size = new System.Drawing.Size(150, 25);
            this.btCadFornecedor.Click += new EventHandler(btCadFornecedor_Click);

            this.Controls.Add(lblidfornecedor);
            this.Controls.Add(txtidfornecedor);
            this.Controls.Add(lblNomefornecedor);
            this.Controls.Add(txtNomefornecedor);
            this.Controls.Add(lblNomeSocial);
            this.Controls.Add(txtNomeSocial);
            this.Controls.Add(lblcnpj);
            this.Controls.Add(txtcnpj);
            this.Controls.Add(lblEndereco);
            this.Controls.Add(txtEndereco);
            this.Controls.Add(lblTelefone);
            this.Controls.Add(txtTelefone);
            this.Controls.Add(btCadFornecedor);
        }   
    }
}