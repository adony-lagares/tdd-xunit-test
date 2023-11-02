using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTDD
{
    public class Calculadora
    {
        private List<String> historicoLista;
        private string data;

        public Calculadora(string data)
        {
            historicoLista = new List<String>();
            this.data = data;
        }
        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            historicoLista.Insert(0, "Res: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            historicoLista.Insert(0, "Res: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            historicoLista.Insert(0, "Res: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            historicoLista.Insert(0, "Res: " + resultado + " - data: " + data);
            return resultado;
        }

        public List<string> historico()
        {
            List<string> resultado;
            historicoLista.RemoveRange(3, historicoLista.Count - 3);
            return historicoLista;
        }
    }
}
