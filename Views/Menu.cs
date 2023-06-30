namespace Views{
    public class Menu{
        
        public static void index(){
            Form menu = new Form();
            
            menu.Text = "Menu";
            menu.Size = new Size(300, 450);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;
            menu.ShowIcon = false;
            menu.ShowInTaskbar = false;
            menu.BackColor = ColorTranslator.FromHtml("#877C78");

            Button btProduto = new Button();
            btProduto.Text = "Cadastrar Produto";
            btProduto.Size = new Size(130,30);
            btProduto.Location = new Point(80,80);
            btProduto.Click += (sender, e) =>{
                menu.Hide();
                var CadProduto = new ProdutoCreate();
                CadProduto.ShowDialog();
                menu.Show();
            };
            Button btProdutoList = new Button();
            btProdutoList.Font = new Font("Verdana", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btProdutoList.BackColor = ColorTranslator.FromHtml("#B6B4B3");
            btProdutoList.Text = "Listar Produto";
            btProdutoList.Size = new Size(130,30);
            btProdutoList.Location = new Point(80,120);
            btProdutoList.Click += (sender, e) =>{
                menu.Hide();
                var ListProduto = new ProdutoView();
                ListProduto.ShowDialog();
                menu.Show();
            };
            Button btFornecedor = new Button();
            btFornecedor.Text = "Cadastrar Fornecedor";
            btFornecedor.Size = new Size(130,30);
            btFornecedor.Location = new Point(80, 160);
            btFornecedor.Click += (sender, e) =>{
                menu.Hide();
                var CadFornecedor = new FornecedorCreate();
                CadFornecedor.ShowDialog();
                menu.Show();
            };
            Button btFornecedorList = new Button();
            btFornecedorList.Text = "Listar Fornecedor";
            btFornecedorList.Size = new Size(130,30);
            btFornecedorList.Location = new Point(80,200);
            btFornecedorList.Click += (sender, e) => {
                menu.Hide();
                var ListFornecedor = new FornecedorView();
                ListFornecedor.ShowDialog();
                menu.Show();
            };
            Button btSair = new Button();
            btSair.Text = "Sair";
            btSair.Size = new Size(100,30);
            btSair.Location = new Point(95,300);
            btSair.Click += (sender, e) =>{
                menu.Close();
            };


            menu.Controls.Add(btProduto);
            menu.Controls.Add(btProdutoList);
            menu.Controls.Add(btFornecedor);
            menu.Controls.Add(btFornecedorList);
            menu.Controls.Add(btSair);
            menu.ShowDialog();

        }
    }
}