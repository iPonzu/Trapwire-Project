using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Models{
    public class Produto{

        [Column("ID Produto")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get;set; }
        [Column("Marca")]
        public string Marca { get; set; }
        [Column("Modelo")]
        public string Modelo { get; set; }
        [Column("Categoria")]
        public string Categoria { get; set; }

        public Produto(int id, string marca, string modelo, string categoria){
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Categoria = categoria;
        }
    }
}