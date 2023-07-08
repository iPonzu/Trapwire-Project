namespace Views{
    public class Menu{
        
        public static void index(){
            Form menu = new Form();
            
            menu.Text = "Menu";
            menu.Size = new Size(300, 550);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;
            menu.ShowIcon = false;
            menu.ShowInTaskbar = false;
            menu.BackColor = ColorTranslator.FromHtml("#877C78");

            Label lblTitle = new Label();
            lblTitle.Text = "Menu";
            lblTitle.Font = new Font("Verdana", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Size = new Size(100,30);
            lblTitle.Location = new Point(115, 70);


            Button btProdutoList = new Button();
            btProdutoList.Font = new Font("Verdana", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btProdutoList.BackColor = ColorTranslator.FromHtml("#B6B4B3");
            btProdutoList.Text = "Produto";
            btProdutoList.Size = new Size(130,30);
            btProdutoList.Location = new Point(80,120);
            btProdutoList.Click += (sender, e) =>{
                menu.Hide();
                var ListProduto = new ProdutoView();
                ListProduto.ShowDialog();
                menu.Show();
            };

            Button btFornecedorList = new Button();
            btFornecedorList.Text = "Fornecedor";
            btFornecedorList.Size = new Size(130,30);
            btFornecedorList.Location = new Point(80,160);
            btFornecedorList.Click += (sender, e) => {
                menu.Hide();
                var ListFornecedor = new FornecedorView();
                ListFornecedor.ShowDialog();
                menu.Show();
            };


            Button btMarcaList = new Button();
            btMarcaList.Text = "Marca";
            btMarcaList.Size = new Size(130,30);
            btMarcaList.Location = new Point(80,200);
            btMarcaList.Click += (sender, e) =>{
                menu.Hide();
                var ListMarca = new MarcaView();
                ListMarca.ShowDialog();
                menu.Show();
            };

            Button ModeloList = new Button();
            ModeloList.Text = "Modelo";
            ModeloList.Size = new Size(130,30);
            ModeloList.Location = new Point(80,240);
            ModeloList.Click += (sender, e) =>{
                menu.Hide();
                var ListModelo = new ModeloView();
                ListModelo.ShowDialog();
                menu.Show();
            };

            Button LogisticaList = new Button();
            LogisticaList.Text = "Logistica";
            LogisticaList.Size = new Size(130,30);
            LogisticaList.Location = new Point(80,280);
            LogisticaList.Click += (sender, e) =>{
                menu.Hide();
                var ListLogistica = new LogisticaView();
                ListLogistica.ShowDialog();
                menu.Show();
            };

            Button CategoriaList = new Button();
            CategoriaList.Text = "Categoria";
            CategoriaList.Size = new Size(130,30);
            CategoriaList.Location = new Point(80,320);
            CategoriaList.Click += (sender, e) =>{
                menu.Hide();
                var ListCategoria = new CategoriaView();
                ListCategoria.ShowDialog();
                menu.Show();
            };

            Button EstoqueList = new Button();
            EstoqueList.Text = "Estoque";
            EstoqueList.Size = new Size(130,30);
            EstoqueList.Location = new Point(80,360);
            EstoqueList.Click += (sender, e) =>{
                menu.Hide();
                var ListEstoque = new EstoqueView();
                ListEstoque.ShowDialog();
                menu.Show();
            };

            Button btSair = new Button();
            btSair.Text = "Sair";
            btSair.Size = new Size(100,30);
            btSair.Location = new Point(95,420);
            btSair.Click += (sender, e) =>{
                menu.Close();
            };


            menu.Controls.Add(lblTitle);
            menu.Controls.Add(btProdutoList);
            menu.Controls.Add(btFornecedorList);
            menu.Controls.Add(btMarcaList);
            menu.Controls.Add(ModeloList);
            menu.Controls.Add(LogisticaList);
            menu.Controls.Add(CategoriaList);
            menu.Controls.Add(EstoqueList);
            menu.Controls.Add(btSair);
            menu.ShowDialog();

        }
    }
}