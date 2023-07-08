using Models;
using Controllers;

namespace Views{
    public class EstoqueView : Form{
        public enum Option {Update, Delete}

        ListView ListEstoque;

        private void AddListView(Models.EstoqueModels estoque){
            string[] row = {
                estoque.Id.ToString(),
                estoque.Nome.ToString(),
                estoque.Endereco.ToString(),
            };

            ListViewItem item = new ListViewItem(row);
            ListEstoque.Items.Add(item);
        }
        public void RefreshList(){
            ListEstoque.Items.Clear();
            List<EstoqueModels> estoques = EstoqueModels.Read();
            foreach (EstoqueModels estoque in estoques){
                AddListView(estoque);
            }
        }
        public EstoqueModels GetSelectedEstoque(Option option){
            if(ListEstoque.SelectedItems.Count > 0){
                int selectedEstoqueId = int.Parse(ListEstoque.SelectedItems[0].Text);
                return Controllers.EstoqueController.ReadById(selectedEstoqueId);
            }if(option == Option.Update){
                throw new Exception($"Selecione um estoque para {(option == Option.Update ? "Update" : "Delete")}");
            }
            else{
                throw new Exception($"Selecione um estoque para {(option == Option.Delete ? "Update" : "Delete")}");
            }
        }
        private void btCadEstoque_Click(object sender, EventArgs e){
            var EstoqueCreate = new Views.EstoqueCreate();
            EstoqueCreate.Show();
        }
        // private void btEstoqueUpdate_Click(object sender, EventArgs e){
        //     try{
        //         EstoqueModels estoque = GetSelectedEstoque(Option.Update);
        //         RefreshList();
        //         var EstoqueUpdate = new Views.EstoqueUpdate(estoque);
        //         if(EstoqueUpdate.ShowDialog() == DialogResult.OK){
        //             RefreshList();
        //             MessageBox.Show("Estoque atualizado.");
        //         }
        //     }
        //     catch (Exception ex){
        //         MessageBox.Show("Não foi possível atualizar ou excluir o estoque" + ex.Message);
        //     }
        // }

        private void btEstoqueUpdate_Click(object sender, EventArgs e){
            EstoqueModels estoque = GetSelectedEstoque(Option.Update);
            DialogResult result = MessageBox.Show("Tem certeza de que quer atualizar este estoque agora?" , "Confirmar atualização", MessageBoxButtons.YesNo);
            if(estoque != null){
                var EstoqueUpdate = new Views.EstoqueUpdate(estoque);
                if(EstoqueUpdate.ShowDialog() == DialogResult.OK){
                    RefreshList();
                    MessageBox.Show("Estoque atualizado com sucesso");
                }
            }
            RefreshList();
        }


        private void btDelete_Click(object sender, EventArgs e){
            try{
                EstoqueModels estoque = GetSelectedEstoque(Option.Delete);
                DialogResult result = MessageBox.Show("Tem certeza de que quer excluir este estoque agora?" , "Confirmar exclusão", MessageBoxButtons.YesNo);
                if(estoque != null){
                    EstoqueController.Delete(Convert.ToString(estoque.Id),estoque.Nome);
                    RefreshList();
                    MessageBox.Show("Estoque excluído com sucesso");
                }
            }catch (Exception ex){
                MessageBox.Show("Não foi possível excluir este estoque" + ex.Message);
            }
        }
        
        private void btClose_Click(object sender, EventArgs e){
            this.Close();
            Menu.index();
        }

        public EstoqueView(){
            this.Text = "Gerenciar Estoque";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            ListEstoque = new ListView();
            ListEstoque.Size = new Size(680, 260);
            ListEstoque.Location = new Point(50 ,50);
            ListEstoque.View = System.Windows.Forms.View.Details;
            ListEstoque.FullRowSelect = true;
            ListEstoque.Columns.Add("ID", -2, HorizontalAlignment.Center);
            ListEstoque.Columns.Add("Nome", -2, HorizontalAlignment.Center);
            ListEstoque.Columns.Add("Endereço", -2, HorizontalAlignment.Center);
            ListEstoque.Columns[0].Width = 50;
            ListEstoque.Columns[1].Width = 100;
            ListEstoque.Columns[2].Width = 100;

            RefreshList();

            Button btCad = new Button();
            btCad.Text = "Cadastrar";
            btCad.Size = new Size(100, 30);
            btCad.Location = new Point(50, 330);
            btCad.Click += new EventHandler(btCadEstoque_Click);

            Button btUpdate = new Button();
            btUpdate.Text = "Editar";
            btUpdate.Size = new Size(100, 30);
            btUpdate.Location = new Point(170, 330);
            btUpdate.Click += new EventHandler(btEstoqueUpdate_Click);

            Button btDelete = new Button();
            btDelete.Text = "Excluir";
            btDelete.Size = new Size(100, 30);
            btDelete.Location = new Point(290, 330);
            btDelete.Click += new EventHandler(btDelete_Click);

            Button btClose = new Button();
            btClose.Text = "Voltar";
            btClose.Size = new Size(100, 30);
            btClose.Location = new Point(450, 330);
            btClose.Click += new EventHandler(btClose_Click);

            Controls.Add(ListEstoque);
            Controls.Add(btCad);
            Controls.Add(btUpdate);
            Controls.Add(btDelete);
            Controls.Add(btClose);
        }
    }
}