using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class BancaPersonal
    {
        // atributos privados
        private string _nombre;
        public string getNombre()
        {
            return _nombre;
        }
        public void setNombre(string nom)
        {
            _nombre = nom;
        }
        private string _apellido;
        public string getApellido()
        {
            return _apellido;
        }
        public void setApellido(string ape)
        {
            _apellido = ape;
        }
        private DateTime _nacimiento;
        public string getNacimiento()
        {
            return _nacimiento.ToString();
        }
        public void setNacimiento(DateTime naci)
        {
            _nacimiento = naci;
        }
        private int _dni;
        public int getDNI()
        {
            return _dni;
        }
        public void setDNI(int dni)
        {
            _dni = dni;
        }

        // propiedades
        public int _numcuenta;
        public int NumCuenta { get; set; }
        public string Moneda { get; set; }
        public double Saldo { get; set; }
        public int Edad
        {
            get { return CalculoEdad(); }
        }

        // Metodo para calcular edad
        private int CalculoEdad()
        {
            int edad = DateTime.Now.Year - _nacimiento.Year;
            if (DateTime.Now.Month < _nacimiento.Month)
            {
                edad -= 1;
            }
            if (DateTime.Now.Month == _nacimiento.Month && DateTime.Now.Day < _nacimiento.Day)
            {
                edad -= 1;
            }
            return edad;
        }

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
