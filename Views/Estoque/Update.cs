using Models;
using Controllers;

namespace Views{
    public class EstoqueUpdate : Form{
        public Label lblid;
        public TextBox txtid;
        public Label lblnomeEstoque;
        public TextBox txtnomeEstoque;
        public Label lblenderecoEstoque;
        public TextBox txtenderecoEstoque;
        public Button btUpEstoque;

        public EstoqueModels estoque;

        private void btUpEstoque_Click(object sender, EventArgs e){
            EstoqueModels estoque = this.estoque;
            
        }
        
    }
}