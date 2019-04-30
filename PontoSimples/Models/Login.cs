using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models
{
    [Serializable]
    [Table("usuarios")]
    public class Login
    {
        [Column("IdUsuario")]
        public int Id { get; set; }
        [Column("Login")]
        [Required(ErrorMessage = "Informe um usuário válido")]
        public string Usuario { get; set; }
        [Column("Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }
        [Column("Nome")]
        [Required(ErrorMessage = "Informe um nome válido")]
        public string Nome { get; set; }
        [Column("Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }

        public Login()
        {
        }

        public Login(int idLogin, string usuario, string senha, string nome, string email)
        {
            Id = idLogin;
            Usuario = usuario;
            Senha = senha;
            Nome = nome;
            Email = email;
        }
    }
}
