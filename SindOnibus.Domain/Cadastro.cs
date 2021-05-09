using System;

namespace SindOnibus.Domain
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasci { get; set; }
        public string ImageURL { get; set; }
    }
}