using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Controllers
{
    public class CalculadoraControllers
    {
        private List<string> historico;

        public CalculadoraControllers()
        {
            historico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {    
            historico.Insert(0, $"{num1} + {num2} = {num1+num2}");
            return num1 + num2;

        }
        public int Subtrair(int num1, int num2)
        {
            historico.Insert(0, $"{num1} - {num2} = {num1-num2}");    
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            historico.Insert(0, $"{num1} * {num2} = {num1*num2}");    
            return num1 * num2;
        }
        public int Dividir(int num1, int num2)
        {
            historico.Insert(0, $"{num1} / {num2} = {num1/num2}");
            return num1 / num2;
        }

        public List<String> Historico()
        {   
            historico.RemoveRange(3, historico.Count-3);    
            return historico;
        }
    }
}