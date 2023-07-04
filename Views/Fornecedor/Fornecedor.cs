using Models;
using Controllers;

namespace Views{
    public class FornecedorView : Form{
        public enum Option {Update, Delete}

        ListView ListFornecedor;

        private void AddListView(Models.FornecedorModels fornecedor){
            string[] row = {
                fornecedor.Id.ToString(),
                fornecedor.Nome.ToString(),
                fornecedor.NomeSocial.ToString(),
                fornecedor.Endereco.ToString(),
                fornecedor.Cnpj.ToString(),
                fornecedor.Telefone.ToString()
            };

            ListViewItem item = new ListViewItem(row);
            ListFornecedor.Items.Add(item);
        }
        public void RefreshList(){
            ListFornecedor.Items.Clear();
            List<FornecedorModels> fornecedores = FornecedorModels.Read();
            foreach(Models.FornecedorModels fornecedor in fornecedores){
                AddListView(fornecedor);
            }
        }
        public FornecedorModels GetSelectedFornecedor(Option option){
            if(ListFornecedor.SelectedItems.Count > 0){
                int selectedFornecedorId = int.Parse(ListFornecedor.SelectedItems[0].Text);
                return Controllers.FornecedorController.ReadById(selectedFornecedorId);
            }else{
                throw new Exception($"Selecione um fornecedor para {(option == Option.Update ? "Update" : "Delete")}");
            }
        }
        public void btCadFornecedor_Click(object sender, EventArgs e){
            var FornecedorCreate = new Views.FornecedorCreate();
            FornecedorCreate.Show();
        }
        public void btFornecedorUpdate_Click (object sender, EventArgs e){
            try{
                FornecedorModels fornecedor = GetSelectedFornecedor(Option.Update);
                RefreshList();
                var FornecedorUpdate = new Views.FornecedorUpdate(fornecedor);
                if(FornecedorUpdate.ShowDialog() == DialogResult.OK){
                   RefreshList();
                   MessageBox.Show("Fornecedor atualizado com sucesso"); 
                }
            } catch (Exception err) {
                MessageBox.Show("Não foi possível excluir o fornecedor desejado" + err.Message);
            }
        }
        private void btDelete_Click(object sender, EventArgs e){
            try{
                FornecedorModels fornecedor = GetSelectedFornecedor(Option.Delete);
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir este fornecedor?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes){
                    Controllers.FornecedorController.Delete(fornecedor.Nome);
                }
            }catch(Exception err){
                MessageBox.Show("Não foi possível excluir o fornecedor" + err.Message);
            }
        }
        private void btClose_Click(object sender, EventArgs e){
            this.Close();
        }
        public FornecedorView(){
            
            this.Text = "Lista de Fornecedores";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            ListFornecedor = new ListView();
            ListFornecedor.Size = new System.Drawing.Size(780, 500);
            ListFornecedor.Location = new System.Drawing.Point(50, 50);
            ListFornecedor.View = System.Windows.Forms.View.Details;
            ListFornecedor.FullRowSelect = true;
            ListFornecedor.Columns.Add("Id", -2, HorizontalAlignment.Center);
            ListFornecedor.Columns.Add("Nome", -2, HorizontalAlignment.Center);
            ListFornecedor.Columns.Add("Nome Social", -2, HorizontalAlignment.Center);
            ListFornecedor.Columns.Add("Endereço", -2, HorizontalAlignment.Center); 
            ListFornecedor.Columns.Add("CNPJ", -2, HorizontalAlignment.Center);
            ListFornecedor.Columns.Add("Telefone", -2, HorizontalAlignment.Center);
            ListFornecedor.Columns[0].Width = 50;
            ListFornecedor.Columns[1].Width = 100;
            ListFornecedor.Columns[2].Width = 100;
            ListFornecedor.Columns[3].Width = 100;
            ListFornecedor.Columns[4].Width = 100;
            ListFornecedor.Columns[5].Width = 100;

            RefreshList();

            Button btCadFornecedor = new Button();
            btCadFornecedor.Text = "Cadastrar";
            btCadFornecedor.Location = new System.Drawing.Point(50, 550);
            btCadFornecedor.Click += new EventHandler(btCadFornecedor_Click);

            Button btFornecedorUpdate = new Button();
            btFornecedorUpdate.Text = "Atualizar";
            btFornecedorUpdate.Location = new System.Drawing.Point(150, 550);
            btFornecedorUpdate.Click += new EventHandler(btFornecedorUpdate_Click);

            Button btDelete = new Button();
            btDelete.Text = "Deletar";
            btDelete.Location = new System.Drawing.Point(250, 550);
            btDelete.Click += new EventHandler(btDelete_Click);

            Button btClose = new Button();
            btClose.Text = "Fechar";
            btClose.Location = new System.Drawing.Point(350, 550);
            btClose.Click += new EventHandler(btClose_Click);

            Controls.Add(ListFornecedor);
            Controls.Add(btCadFornecedor);
            Controls.Add(btFornecedorUpdate);
            Controls.Add(btDelete);
            Controls.Add(btClose);
        }
    }
}