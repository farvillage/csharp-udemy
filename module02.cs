using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOut
{
    class Program
	{
        static void Main(string[] args)
		{
			#region In n Out
			//Console.WriteLine("Ygor");
			//Console.Write("Carvalho");

			//int code = Console.Read();
			//Console.WriteLine(code);

			//tring text = Console.ReadLine();
			//Console.WriteLine(text);

			Console.ReadKey();
			#endregion

			#region Inverted Numbers
			string name1, name2, name3, name4, aux;

			Console.WriteLine("Enter name #1: ");
			name1 = Console.ReadLine();

			Console.WriteLine("Enter name #2: ");
			name2 = Console.ReadLine();

			Console.WriteLine("Enter name #3: ");
			name3 = Console.ReadLine();

			Console.WriteLine("Enter name #4: ");
			name4 = Console.ReadLine();

            //Inverted numbers mechanism:

			aux = name1;
			name1 = name4;
			name4 = aux;
			aux = name2;
			name2 = name3;
			name3 = aux;

			Console.WriteLine();
			Console.WriteLine("Inverted name sequence");
			Console.WriteLine(name1);
			Console.WriteLine(name2);
			Console.WriteLine(name3);
			Console.WriteLine(name4);

			Console.ReadKey();
			#endregion
		}
	}
}