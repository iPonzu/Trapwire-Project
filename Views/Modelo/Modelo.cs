using Models;
using Controllers;

namespace Views{
    public class ModeloView : Form{
        public enum Option{Update, Delete};

        ListView ListModelo;

        private void AddListView(Models.ModeloModels modelo){
            string[]row = {
                modelo.Id.ToString(),
                modelo.Nome.ToString(),
                modelo.Marcaid.ToString(),
            };
            ListViewItem item = new ListViewItem(row);
            ListModelo.Items.Add(item);
        }

        public void RefreshList(){
            ListModelo.Items.Clear();
            List<ModeloModels> modelos = ModeloModels.Read();
            foreach (ModeloModels modelo in modelos){
                AddListView(modelo);
            }
        }

        public ModeloModels GetSelectedModelo(Option option){
            if(ListModelo.SelectedItems.Count > 0){
                int selectedModeloId = int.Parse(ListModelo.SelectedItems[0].Text);
                return Controllers.ModeloController.ReadById(selectedModeloId);
            }if(option == Option.Update){
                throw new Exception("Selecione um modelo para atualizar");
            }else{
                throw new Exception("Selecione um modelo para excluir");    
            }
        }

        private void btCadModelo_Click (object sender, EventArgs e){
            var ModeloCreate = new Views.ModeloCreate();
            ModeloCreate.Show();
        }

        private void btModeloUpdate_Click (object sender, EventArgs e){
            try{
                ModeloModels modelo = GetSelectedModelo(Option.Update);
                var ModeloUpdate = new Views.ModeloUpdate(modelo);
                if(ModeloUpdate.ShowDialog() == DialogResult.OK){
                    RefreshList();
                    MessageBox.Show("Modelo Atualizado com sucesso");
                }
            } catch (Exception err) {
                MessageBox.Show("Não foi possível editar o modelo desejado" + err.Message);
            }
            RefreshList();
        }

        private void btDelete_Click(object sender, EventArgs e){
            try{
                ModeloModels modelo = GetSelectedModelo(Option.Delete);
                if(modelo != null){
                    ModeloController.Delete(Convert.ToString(modelo.Id), modelo.Nome);
                    RefreshList();
                    MessageBox.Show("Modelo excluído com sucesso");
                }

            }catch (Exception err){
                MessageBox.Show("Não foi possível excluir o modelo desejado" + err.Message);
            }
        }

        private void btClose_Click(object sender, EventArgs e){
            this.Close();
            Menu.index();
        }
   

        public ModeloView(){
            this.Text = "Gerenciar Modelos";
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

            this.Controls.Add(ListModelo);
            this.Controls.Add(btCad);
            this.Controls.Add(btUpdate);
            this.Controls.Add(btDelete);
            this.Controls.Add(btClose);
        }

    }
}