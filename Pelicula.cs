using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos

{
    public class Pelicula
    {
        List<Class1> lista = new List<Class1>();
        public void Guardar(Class1 modelo) {
            lista.Add(modelo);
        }
        public List<Class1> Consultar() {
            return lista;
        }
    }
}
