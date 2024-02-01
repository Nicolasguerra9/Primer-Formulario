﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFileForEver
{
    internal class Json
    {
        public string Name { get; set; }
        public string Tipo { get; set; }
        public DateTime ultimaModificacion { get; set; }
        public DateTime creationDate { get; set; }
        public string FullName { get; set; }


        public Json()
        {

        }

        public Json(string Name, string Tipo, DateTime ultimaModificacion, DateTime creationDate, string fullName)
        {
            this.Name = Name;
            this.Tipo = Tipo;
            this.ultimaModificacion = ultimaModificacion;
            this.creationDate = creationDate;
            FullName = fullName;
        }





    }
}
