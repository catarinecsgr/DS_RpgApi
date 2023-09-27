using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RpgApi.Models
{
    public class Usuario
    {
        public int Id { get; set; } //Atalho para propridade (PROP + TAB)
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; } // o [] siginifa que é uma array 
        public byte[] PasswordSalt { get; set; } 
        public byte[]? Foto { get; set; }
        public double? Latitude { get; set; } //tipo de variável com interrogação significa q ela pode virar um campo nulo no banco de dados
        public double? Longitude { get; set; }
        public DateTime? DataAcesso { get; set; } //using System;

        [NotMapped] // using System.ComponentModel.DataAnnotations.Schema
        public string PasswordString { get; set; }
        public List<Personagem> Personagens { get; set; }
        public string Perfil { get; set; }
        public string Email { get; set; }

    }
}