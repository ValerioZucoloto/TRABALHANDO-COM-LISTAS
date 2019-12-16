using System;

class Funcionario {
        public string Nome {get; set;}
        public int Id {get; private set;}
        public double Salario {get; set;}

        public Funcionario (string nome, int id, double salario) {
                Nome = nome;
                Id = id;
                Salario = salario;
        }

        public void IncrementarSalario(double porcentagem) {
                Salario = Salario * porcentagem/ 100.0;
        }

        public override string ToString() {
                return "\nNome: " + Nome
                + "\nId: " + Id
                + "\nSalário: " + Salario.ToString("F2"); 
        }
}