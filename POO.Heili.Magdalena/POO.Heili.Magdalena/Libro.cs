﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor {  get; set; }

        public Libro(string titulo, string autor) 
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}
