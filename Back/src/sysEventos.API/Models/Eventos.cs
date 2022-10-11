using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sysEventos.API.Models
{
    public class Eventos
    {
        public int EventoId{ get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QntPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }

    }
}