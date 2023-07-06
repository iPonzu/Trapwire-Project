using Models;
using Controllers;

namespace Views{
    public class ModeloView : Form{
        public enum Option {Update, Delete}

        ListView ListModelo;

        private void AddListView(Models.ModeloModels modelo){
            string[] row = {
                modelo.Id.ToString(),
                modelo.Nome.ToString()
           };   
        }
        public void RefreshList(){
            ListModelo.Items.Clear();
            List<ModeloModels> modelos = ModeloModels.Read();
            foreach (ModeloModels modelo in modelos){
                AddListView(modelo);
            }
        }

        public ModeloModels GetSelectedModelo(Option option){
            if(ListModelo.SelectedItems.Count == 0){
                int selectedModeloId = int.Parse(ListModelo.SelectedItems[0].Text);
                return Controllers.ModeloController.ReadById(selectedModeloId);
            }else{
                throw new Exception($"Selecione um modelo para {(option == Option.Update ? "Update" : "Delete")}");
            }
        }

        
        public void btCadModelo_Click (object sender, EventArgs e){
            var ModeloCreate = new Views.ModeloCreate();
            ModeloCreate.Show();
        }
        
        public void btModeloUpdate_Click (object sender, EventArgs e){
            try{
                ModeloModels modelo = GetSelectedModelo(Option.Update);
                RefreshList();
                var ModeloUpdate = new Views.ModeloUpdate(modelo);
                if(ModeloUpdate.ShowDialog() == DialogResult.OK){
                   RefreshList();
                   MessageBox.Show("Modelo atualizado com sucesso"); 
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possível excluir o modelo desejado" + ex.Message);
            }
        }
        
        private void btDelete_Click (object sender, EventArgs e){
            try{
                ModeloModels Modelo = GetSelectedModelo(Option.Delete);
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir esta Modelo agora?" , "Confirmar exlcusão", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes){
                    Controllers.ModeloController.Delete(Modelo.Nome);
                    RefreshList();
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possível excluir a Modelo" + ex.Message);
            }
        }

        private void btClose_Click (object sender, EventArgs e){
            this.Close();
        }

        public ModeloView(){
            this.Text = "Verificar Modelo";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            ListModelo = new ListView();
            ListModelo.Size = new Size(680, 260);
            ListModelo.Location = new Point(50 ,50);
            ListModelo.View = System.Windows.Forms.View.Details;
            ListModelo.FullRowSelect = true;
            ListModelo.Columns.Add("ID", -2, HorizontalAlignment.Center);
            ListModelo.Columns.Add("Nome", -2, HorizontalAlignment.Center);
            ListModelo.Columns[0].Width = 50;
            ListModelo.Columns[1].Width = 100;

            RefreshList();

            Button btCad = new Button();
            btCad.Text = "Cadastrar";
            btCad.Size = new Size(100, 30);
            btCad.Location = new Point(50, 330);
            btCad.Click += new EventHandler(btCadModelo_Click);

            Button btUpdate = new Button();
            btUpdate.Text = "Editar";
            btUpdate.Size = new Size(100, 30);
            btUpdate.Location = new Point(170, 330);
            btUpdate.Click += new EventHandler(btModeloUpdate_Click);

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

            Controls.Add(ListModelo);
            Controls.Add(btCad);
            Controls.Add(btUpdate);
            Controls.Add(btDelete);
            Controls.Add(btClose);
        }
    }
}