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
        
    }
}