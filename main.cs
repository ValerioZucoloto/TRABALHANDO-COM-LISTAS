using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ();

    Console.WriteLine ("Informe quantos funcionários serão registrados: ");
    int x = int.Parse (Console.ReadLine());

    List <Funcionario> list = new List<Funcionario>();

    for (int i=1; i <= x; i++) {
            Console.WriteLine ("Funcionário # " + i + ":");
            Console.Write ("Nome: ");
            string nome = Console.ReadLine();
            Console.Write ("ID: ");
            int id = int.Parse (Console.ReadLine());
            Console.Write("Salário: ");
            double salario = double.Parse (Console.ReadLine());
            list.Add (new Funcionario(nome,id, salario));
            Console.WriteLine();
    }

    Console.WriteLine ("Qual o ID do funcionário que terá o salário incrementado ? ");
    int Idsorte = int.Parse (Console.ReadLine());

    Funcionario func = list.Find (n => n.Id == Idsorte);
    if (func != null) {
            Console.WriteLine("Qual a porcentagem que deseja aumentar? ");
            int n = int.Parse(Console.ReadLine());
            func.IncrementarSalario(n);
    }
    else{
            Console.WriteLine ("Código ID inexistente!");
    }
  }
}