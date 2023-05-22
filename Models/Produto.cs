using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Models{
    public class Produto{

        [Column("ID Produto")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idproduto { get;set; }
        [Column("Marca")]
        public string Marca { get; set; }
        [Column("Modelo")]
        public string Modelo { get; set; }
        [Column("Categoria")]
        public string Categoria { get; set; }

        public Produto(int idproduto, string marca, string modelo, string categoria){
            this.Idproduto = idproduto;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Categoria = categoria;
        }
    }
}