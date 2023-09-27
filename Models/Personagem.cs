using RpgApi.Models.Enuns;
using System.Text.Json.Serialization;

namespace RpgApi.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClasseEnum Classe { get; set; }
        public byte[]? FotoPersonagem { get; set; } // o [] siginifa que é uma array de "bytes" 
        [JsonIgnore]
        public Usuario? Usuario { get; set; } //propriedade de navegação / consigo visualizar o username de determinado usuário
        public Arma Arma { get; set; }
    }
}