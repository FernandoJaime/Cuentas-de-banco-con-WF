using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class BancaEmpresa
    {
        // atributos privados
        private string _direccion;
        public string getDireccion()
        {
            return _direccion;
        }
        public void setDireccion(string direc)
        {
            _direccion = direc;
        }
        private string _fiscal;
        public string getFiscal()
        {
            return _fiscal;
        }
        public void setFiscal(string fis)
        {
            _fiscal = fis;
        }

        // propiedades
        public int _cuit;
        public int CUIT { get; set; }
        public string Nombre { get; set; }
        public string Moneda { get; set; }
        public double Saldo { get; set; }

        // Metodo de la clase para depositar 
        public void Depositar(double dep)
        {
            this.Saldo += dep;
        }

        // Metodo de la clase para extraer 
        public bool Extraer(double ext)
        {
            if (ext > 0)
            {
                if (ext <= Saldo)
                {
                    this.Saldo -= ext;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
