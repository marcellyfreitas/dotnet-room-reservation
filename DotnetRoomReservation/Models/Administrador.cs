﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotnetRoomReservation.Models
{
    [Table("administradores")]
    public class Administrador
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Preenchimento do Campo 'nome' Obrigatório!")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Preenchimento do Campo 'email' Obrigatório!")]
        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Required(ErrorMessage = "Preenchimento do Campo 'senha' Obrigatório!")]
        [Display(Name = "Senha")]
        public string senha { get; set; }

        [Display(Name = "CPF")]
        public string? cpf { get; set; } = "";

        [Display(Name = "Permissões")]
        public string? permissoes { get; set; } = "";

        public string? created_at { get; set; } = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}";

        public string? updated_at { get; set; } = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
    }
}