﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
