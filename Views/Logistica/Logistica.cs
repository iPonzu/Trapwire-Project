using Models;
using Controllers;

namespace Views{
    public class LogisticaView : Form{
        public enum Option {Update, Delete}

        ListView ListLogistica;

        private void AddListView(Models.LogisticaModels logistica){
            string[] row = {
                logistica.Data.ToString(),
                logistica.Quantidade.ToString(),
                logistica.Produtoid,
                logistica.Estoqueid
            };
            ListViewItem item = new ListViewItem(row);
            ListLogistica.Items.Add(item);
        }
        public void RefreshList(){
            ListLogistica.Items.Clear();
            List<Models.LogisticaModels> logisticas = LogisticaModels.Read();
            foreach(Models.LogisticaModels logistica in logisticas){
                AddListView(logistica);
            }
        }

        public LogisticaModels GetSelectedLogistica(Option option){
            if(ListLogistica.SelectedItems.Count > 0){
                int selectedLogisticaId = int.Parse(ListLogistica.SelectedItems[0].Text);
                return Controllers.LogisticaController.ReadById(selectedLogisticaId);
            }if(option == Option.Update){
                throw new Exception("Selecione uma logistica para atualizar");
            }else{
                throw new Exception("Selecione uma logistica para deletar");
            }
        }

        private void btCadLogistica_Click (object sender, EventArgs e){
            var LogisticaCreate = new Views.LogisticaCreate();
            LogisticaCreate.Show();
        }

        private void btLogisticaUpdate_Click (object sender, EventArgs e){
            try{
                LogisticaModels logistica = GetSelectedLogistica(Option.Update);
                RefreshList();
                var LogisticaUpdate = new Views.LogisticaUpdate(logistica);
                if(LogisticaUpdate.ShowDialog() == DialogResult.OK){
                    RefreshList();
                    MessageBox.Show("Logistica atualizada com sucesso");
                }
            } catch (Exception err) {
                MessageBox.Show("Não foi possível atualizar a logistica desejada" + err.Message);
            }
        }

        private void btDelete_Click (object sender, EventArgs e){
            try{
                LogisticaModels logistica = GetSelectedLogistica(Option.Delete);
                LogisticaController.Delete(Convert.ToString(logistica.Id));
                RefreshList();
                MessageBox.Show("Logistica deletada com sucesso");
            } catch (Exception err) {
                MessageBox.Show("Não foi possível deletar a logistica desejada" + err.Message);
            }
        }

        private void btClose_Click (object sender, EventArgs e){
            this.Close();
            Menu.index();
        }

        public LogisticaView(){
            this.Text = "Gerenciar Logistica";
            this.Size = new System.Drawing.Size(800, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            ListLogistica = new ListView();
            ListLogistica.Size = new System.Drawing.Size(780, 500);
            ListLogistica.Location = new System.Drawing.Point(50, 50);
            ListLogistica.View = System.Windows.Forms.View.Details;
            ListLogistica.FullRowSelect = true;
            ListLogistica.Columns.Add("Data", -2, HorizontalAlignment.Center);
            ListLogistica.Columns.Add("Quantidade", -2, HorizontalAlignment.Center);
            ListLogistica.Columns.Add("Produto", -2, HorizontalAlignment.Center);
            ListLogistica.Columns.Add("Estoque", -2, HorizontalAlignment.Center); 
            ListLogistica.Columns[0].Width = 50;
            ListLogistica.Columns[1].Width = 100;
            ListLogistica.Columns[2].Width = 100;
            ListLogistica.Columns[3].Width = 100;

            RefreshList();

            Button btCadLogistica = new Button();
            btCadLogistica.Text = "Cadastrar";
            btCadLogistica.Location = new System.Drawing.Point(50, 550);
            btCadLogistica.Click += new EventHandler(btCadLogistica_Click);

            Button btLogisticaUpdate = new Button();
            btLogisticaUpdate.Text = "Atualizar";
            btLogisticaUpdate.Location = new System.Drawing.Point(150, 550);
            btLogisticaUpdate.Click += new EventHandler(btLogisticaUpdate_Click);

            Button btDelete = new Button();
            btDelete.Text = "Deletar";
            btDelete.Location = new System.Drawing.Point(250, 550);
            btDelete.Click += new EventHandler(btDelete_Click);

            Button btClose = new Button();
            btClose.Text = "Fechar";
            btClose.Location = new System.Drawing.Point(350, 550);
            btClose.Click += new EventHandler(btClose_Click);

            Controls.Add(ListLogistica);
            Controls.Add(btCadLogistica);
            Controls.Add(btLogisticaUpdate);
            Controls.Add(btDelete);
            Controls.Add(btClose);
        }
    }
}