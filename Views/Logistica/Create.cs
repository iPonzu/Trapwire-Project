using Models;
using Controllers;
using System.Windows.Forms;

namespace Views{
    public class LogisticaCreate : Form{
        public Label lblDate;
        public TextBox txtDate;
        public Label lblQuantidade;
        public TextBox txtQuantidade;
        public Label lblProduto;
        public TextBox txtProduto;
        public Label lblEstoque;
        public TextBox txtEstoque;
        public Button btCadLogistica;

        
        public void btCadLogistica_Click(object sender, EventArgs e){
            if(txtDate.Text == "" || txtQuantidade.Text == "" || txtEstoque.Text == "" || txtProduto.Text == ""){
                MessageBox.Show("Preencha os campos!");
                return;
            }else{
                LogisticaController.Create(txtDate.Text, int.Parse(txtQuantidade.Text) ,txtProduto.Text, txtEstoque.Text);
                MessageBox.Show("Logistica cadastrada com sucesso!");
                ClearForm();
            }
            LogisticaView logisticaList = Application.OpenForms.OfType<LogisticaView>().FirstOrDefault();
            if(logisticaList != null){
                logisticaList.RefreshList();
            }
            this.Close();
        }

        private void ClearForm(){
            txtDate.Clear();
            txtEstoque.Clear();
            txtProduto.Clear();
        }
        
        public LogisticaCreate(){
            this.Text = "Registrar Logística";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(344,320);
        
            this.lblDate = new Label();
            this.lblDate.Text = "Data:";
            this.lblDate.Location = new System.Drawing.Point(10, 40);
            this.lblDate.Size = new System.Drawing.Size(70, 20);

            this.txtDate = new TextBox();
            this.txtDate.Location = new System.Drawing.Point(90, 40);
            this.txtDate.Size = new System.Drawing.Size(150, 20);

            this.lblQuantidade = new Label();
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.Location = new System.Drawing.Point(10, 70);
            this.lblQuantidade.Size = new System.Drawing.Size(50, 20);

            this.txtQuantidade = new TextBox();
            this.txtQuantidade.Location = new System.Drawing.Point(90, 70);
            this.txtQuantidade.Size = new System.Drawing.Size(150, 20);

            this.lblProduto = new Label();
            this.lblProduto.Text = "Produto:";
            this.lblProduto.Location = new System.Drawing.Point(10, 100);
            this.lblProduto.Size = new System.Drawing.Size(50, 20);

            this.txtProduto = new TextBox();
            this.txtProduto.Location = new System.Drawing.Point(90, 100);
            this.txtProduto.Size = new System.Drawing.Size(150, 20);

            this.lblEstoque = new Label();
            this.lblEstoque.Text = "Estoque:";
            this.lblEstoque.Location = new System.Drawing.Point(10, 130);
            this.lblEstoque.Size = new System.Drawing.Size(50, 20);

            this.txtEstoque = new TextBox();
            this.txtEstoque.Location = new System.Drawing.Point(90, 130);
            this.txtEstoque.Size = new System.Drawing.Size(150, 20);

            this.btCadLogistica = new Button();
            this.btCadLogistica.Text = "Cadastrar";
            this.btCadLogistica.Location = new System.Drawing.Point(90, 180);
            this.btCadLogistica.Size = new System.Drawing.Size(150, 25);
            this.btCadLogistica.Click += new EventHandler(btCadLogistica_Click);

            this.Controls.Add(lblDate);
            this.Controls.Add(txtDate);
            this.Controls.Add(lblQuantidade);
            this.Controls.Add(txtQuantidade);
            this.Controls.Add(lblProduto);
            this.Controls.Add(txtProduto);
            this.Controls.Add(lblEstoque);
            this.Controls.Add(txtEstoque);
            this.Controls.Add(btCadLogistica);
        }
    }
}