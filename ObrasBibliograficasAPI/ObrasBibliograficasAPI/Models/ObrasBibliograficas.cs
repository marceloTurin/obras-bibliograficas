using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObrasBibliograficasAPI.Models {
    public class ObrasBibliograficas {
        public int Id { get; set; }
        public string NomeAutor { get; set; }

        public ObrasBibliograficas(int id, string nomeAutor) {
            Id = id;
            NomeAutor = nomeAutor;
        }
        public ObrasBibliograficas() {
                
        }
    }
}
