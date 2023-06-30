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
            
    }
}