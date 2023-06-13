using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using System;
using Models;

namespace MyData{
    public class Context : DbContext{

        public string connection = "Server=localhost;User Id=root;Database=trapwire";
        public DbSet<CategoriaModels> Categorias { get; set; }
        
        public DbSet<ModeloModels> Modelos { get; set; }
        
        public DbSet<ProdutoModels> Produtos { get; set; }

        public DbSet<MarcaModels> Marcas { get; set; }
        
        public DbSet<FornecedorModels> Fornecedores { get; set; }
        
        public DbSet<LogisticaModels> Logisticas { get; set; }
        
        public DbSet<EstoqueModels> Estoques { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(connection, ServerVersion.AutoDetect(connection));    
    }
}