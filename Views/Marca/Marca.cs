using Models;
using Controllers;

namespace Views{
    public class MarcaView : Form{
        public enum Option {Update, Delete}

        ListView ListMarca;

        private void AddListView(MarcaModels marca){
            string[] row = {
                marca.Id.ToString(),
                marca.Nome.ToString(),
            };
        }
        public void RefreshList(){
            ListMarca.Items.Clear();
            List<MarcaModels> marcas = MarcaModels.Read();
            foreach (MarcaModels marca in marcas){
                AddListView(marca);
            }
        }

        public MarcaModels GetSelectedMarca(Option option){
            if(ListMarca.SelectedItems.Count == 0){
                int selectedMarcaId = int.Parse(ListMarca.SelectedItems[0].Text);
                return Controllers.MarcaController.ReadById(selectedMarcaId);
            }else{
                throw new Exception($"Selecione uma marca para {(option == Option.Update ? "Update" : "Delete")}");
            }
        }

        
        public void btCadMarca_Click (object sender, EventArgs e){
            var MarcaCreate = new Views.MarcaCreate();
            MarcaCreate.Show();
        }
        
        public void btMarcaUpdate_Click (object sender, EventArgs e){
            try{
                MarcaModels marca = GetSelectedMarca(Option.Update);
                RefreshList();
                var MarcaUpdate = new Views.MarcaUpdate(marca);
                if(MarcaUpdate.ShowDialog() == DialogResult.OK){
                   RefreshList();
                   MessageBox.Show("Marca Atualizada com sucesso"); 
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possível excluir a marca desejada" + ex.Message);
            }
        }
        
        private void btDelete_Click (object sender, EventArgs e){
            try{
                MarcaModels Marca = GetSelectedMarca(Option.Delete);
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir esta Marca agora?" , "Confirmar exlcusão", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes){
                    Controllers.MarcaController.Delete(Marca.Nome);
                    RefreshList();
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possível excluir a Marca" + ex.Message);
            }
        }

        private void btClose_Click (object sender, EventArgs e){
            this.Close();
        }

        public MarcaView(){
            this.Text = "Verificar Marca";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            ListMarca = new ListView();
            ListMarca.Size = new Size(680, 260);
            ListMarca.Location = new Point(50 ,50);
            ListMarca.View = System.Windows.Forms.View.Details;
            ListMarca.FullRowSelect = true;
            ListMarca.Columns.Add("ID", -2, HorizontalAlignment.Center);
            ListMarca.Columns.Add("Nome", -2, HorizontalAlignment.Center);
            ListMarca.Columns[0].Width = 50;
            ListMarca.Columns[1].Width = 100;

            RefreshList();

            Button btCad = new Button();
            btCad.Text = "Cadastrar";
            btCad.Size = new Size(100, 30);
            btCad.Location = new Point(50, 330);
            btCad.Click += new EventHandler(btCadMarca_Click);

            Button btUpdate = new Button();
            btUpdate.Text = "Editar";
            btUpdate.Size = new Size(100, 30);
            btUpdate.Location = new Point(170, 330);
            btUpdate.Click += new EventHandler(btMarcaUpdate_Click);

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

            Controls.Add(ListMarca);
            Controls.Add(btCad);
            Controls.Add(btUpdate);
            Controls.Add(btDelete);
            Controls.Add(btClose);
        }
    }
}