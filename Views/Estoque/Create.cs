using Models;
using Controllers;

namespace Views{
    public class EstoqueCreate : Form{
        public Label lblEstoque;
        public TextBox txtEstoque;
        public Label lblEndereco;
        public TextBox txtEndereco;
        public Button btCadEstoque;

        public void btCadEstoque_Click(object sender, EventArgs e){
            if(txtEstoque.Text == null || txtEndereco.Text == null){
                MessageBox.Show("Preencha todos os campos");
                return;
            }else{
                EstoqueController.Create(txtEstoque.Text, txtEndereco.Text);
                MessageBox.Show("Estoque cadastrado com sucesso.");
                ClearForm();
            }

            EstoqueView estoqueList = Application.OpenForms.OfType<EstoqueView>().FirstOrDefault();
        }

        private void ClearForm(){
            txtEstoque.Clear();
            txtEndereco.Clear();
        }

        public EstoqueCreate(){
            Text = "Registrar Estoque";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            Size = new System.Drawing.Size(280, 330);
        
        }
    }
}