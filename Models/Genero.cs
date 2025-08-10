using System.Collections.Generic;

namespace ConectDatabase;

public class Genero
{
        public int Id { get; set; }
        public string Nome { get; set; } 
        
        //Criando uma propriedade de navegação ( interliga duas tabelas ) 
        public List<Anime>Animes { get; set; } = new List<Anime>();
}