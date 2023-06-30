using Controllers;
using Models;

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
                MessageBox.Show("Preencha os campos");
                return;
            }else{
                FornecedorController.Create(txtNomefornecedor.Text,txtNomeSocial.Text, txtEndereco.Text, txtTelefone.Text, txtcnpj.Text);
                MessageBox.Show("Fornecedor cadastrado com sucesso");
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
            Text = "Registrar Fornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(344,383);

            lblidfornecedor = new Label();
            lblidfornecedor.Text = "Fornecedor";
            lblidfornecedor.Location = new System.Drawing.Point(10, 40);
            lblidfornecedor.Size = new System.Drawing.Size(70, 20);

            txtidfornecedor = new TextBox();
            txtidfornecedor.Location = new System.Drawing.Point(90, 40);
            txtidfornecedor.Size = new System.Drawing.Size(150, 20);

            lblNomefornecedor = new Label();
            lblNomefornecedor.Text = "Nome";
            lblNomefornecedor.Location = new System.Drawing.Point(10, 70);
            lblNomefornecedor.Size = new System.Drawing.Size(50, 20);

            txtNomefornecedor = new TextBox();
            txtNomefornecedor.Location = new System.Drawing.Point(90, 70);
            txtNomefornecedor.Size = new System.Drawing.Size(150, 20);

            lblNomeSocial = new Label();
            lblNomeSocial.Text = "Nome Social";
            lblNomeSocial.Location = new System.Drawing.Point(10, 100);
            lblNomeSocial.Size = new System.Drawing.Size(50, 20);

            txtNomeSocial = new TextBox();
            txtNomeSocial.Location = new System.Drawing.Point(90, 100);
            txtNomeSocial.Size = new System.Drawing.Size(150, 20);

            lblcnpj = new Label();
            lblcnpj.Text = "CNPJ";
            lblcnpj.Location = new System.Drawing.Point(10, 130);
            lblcnpj.Size = new System.Drawing.Size(50, 20);

            txtcnpj = new TextBox();
            txtcnpj.Location = new System.Drawing.Point(90, 130);
            txtcnpj.Size = new System.Drawing.Size(150, 20);

            lblEndereco = new Label();
            lblEndereco.Text = "Endereço";
            lblEndereco.Location = new System.Drawing.Point(10, 160);
            lblEndereco.Size = new System.Drawing.Size(50, 20);

            txtEndereco = new TextBox();
            txtEndereco.Location = new System.Drawing.Point(90, 160);
            txtEndereco.Size = new System.Drawing.Size(150, 23);

            lblTelefone = new Label();
            lblTelefone.Text = "Telefone";
            lblTelefone.Location = new System.Drawing.Point(10, 190);
            lblTelefone.Size = new System.Drawing.Size(50, 20);

            txtTelefone = new TextBox();
            txtTelefone.Location = new System.Drawing.Point(90, 190);
            txtTelefone.Size = new System.Drawing.Size(150, 20);

            btCadFornecedor = new Button();
            btCadFornecedor.Text = "Cadastrar";
            btCadFornecedor.Location = new System.Drawing.Point(90, 240);
            btCadFornecedor.Size = new System.Drawing.Size(150, 25);
            btCadFornecedor.Click += new EventHandler(btCadFornecedor_Click);

            Controls.Add(lblidfornecedor);
            Controls.Add(txtidfornecedor);
            Controls.Add(lblNomefornecedor);
            Controls.Add(txtNomefornecedor);
            Controls.Add(lblNomeSocial);
            Controls.Add(txtNomeSocial);
            Controls.Add(lblcnpj);
            Controls.Add(txtcnpj);
            Controls.Add(lblEndereco);
            Controls.Add(txtEndereco);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefone);
            Controls.Add(btCadFornecedor);
        }   
    }
}