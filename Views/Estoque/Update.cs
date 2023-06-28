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
        public Button btUpdateEstoque;

        public EstoqueModels estoque;

        private void btUpdateEstoque_Click(object sender, EventArgs e){
            EstoqueModels estoque = this.estoque;
            
        }
        
    }
}