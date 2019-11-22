using System;
using System.Collections.Generic;

namespace Classes.Abstract
{
    public abstract class Expressao
    {
        public abstract double Calcular(Dictionary<string, object> vars);
    }

    public class Constante : Expressao
    {
        double _valor;
        public Constante(double valor)
        {
            _valor = valor;
        }
        public override double Calcular(Dictionary<string, object> vars)
        {
            return _valor;
        }
    }

    public class VariavelReferencia : Expressao
    {
        string _nome;
        public VariavelReferencia(string nome)
        {
            _nome = nome;
        }
        public override double Calcular(Dictionary<string, object> vars)
        {
            object valor = vars[_nome];
            if (valor == null)
            {
                throw new Exception("Variável desconhecida: " + _nome);
            }

            return Convert.ToDouble(valor);
        }
    }

    public class Operacao : Expressao
    {
        Expressao _esquerda;
        char _operador;
        Expressao _direita;
        public Operacao(Expressao esquerda, char operador, Expressao direita)
        {
            this._esquerda = esquerda;
            this._operador = operador;
            this._direita = direita;
        }
        public override double Calcular(Dictionary<string, object> vars)
        {
            double x = _esquerda.Calcular(vars);
            double y = _direita.Calcular(vars);

            switch (_operador)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/':
                    return x / y;
            }

            throw new Exception("Operador desconhecido");
        }

        public static void ExemploUtilizacao()
        {
            Expressao e = new Operacao(
                new VariavelReferencia("x"),
                '*',
                new Operacao(
                    new VariavelReferencia("y"),
                    '+',
                    new Constante(2)
                )
            );
            Dictionary<string, object> vars = new Dictionary<string, object>();
            vars["x"] = 3;
            vars["y"] = 5;
            Console.WriteLine(e.Calcular(vars));        // Escreve "21"
            
            vars["x"] = 1.5;
            vars["y"] = 9;
            Console.WriteLine(e.Calcular(vars));        // Escreve "16.5"
        }
    }
}