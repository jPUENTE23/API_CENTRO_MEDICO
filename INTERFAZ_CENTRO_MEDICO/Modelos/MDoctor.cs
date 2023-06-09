﻿using System;

namespace INTERFAZ_CENTRO_MEDICO.Modelos
{
    public class MDoctor
    {
        public int IdDoctor { get; set; }
        public string Nombre { get; set; }
        public string Apeterno { get; set; }
        public string Amaterno { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public int IsActivo { get; set; }
        public dynamic IdArea { get; set; }
    }
}
