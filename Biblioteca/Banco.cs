using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Banco
    {
        // constructores
        public Banco()
        {
            Empresas = new List<BancaEmpresa>();
            Personas = new List<BancaPersonal>();
        }
        // propiedades
        public List<BancaEmpresa> Empresas { get; set; }
        public List<BancaPersonal> Personas { get; set; }
    }
}
