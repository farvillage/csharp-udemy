using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    enum Grades
	{
        Min = 0,
        Average = 7,
        Max = 10
	}

    struct Person
	{
        public string name;
        public int age;
        public double height;
	}

    class Program
	{
        static void Main(string[] args)
		{
			#region Integral Numbers
			// Full integral
			sbyte num1 = 10; // 8 bits, de -128 a 127
			short num2 = 20; // 16 bits, -32.768 a 32.767
			int num3 = 30; // 32 bits, -2.147.483.648 a 2.147.483.647
			long num4 = 40L; // 64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

			// Unsigned integral  
			byte num5 = 10; // 8 bits, intervalo de 0 a 255
			ushort num6 = 20; // 16 bits, de 0 a 65.535
			uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
			ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

			sbyte number;
			number = 100;

			number = 120;
			number = num1;
			#endregion

			#region Real Numbers
			float real1 = 100.75f; // 32 bits, de 1,5 x 10-45 a 3,4 x 1038, precisão de 7 dígitos => Sufixo f, Ex.: 10.5f
			double real2 = 12500.45; // 64 bits, de 5,0 x 10-324 a 1,7 x 10308, precisão de 15 dígitos => Sufixo d (opcional)
			decimal real3 = 752538.457m; // 128 bits, intervalo de pelo menos -7.9 x 10-28 a 7,9 x 1028, com precisão de p

			double value;
			value = real2;
			#endregion

			#region Char
			char letter = '\u0041';
			char escape = '\n';
			char literal = 'C';
			#endregion

			#region Boolean
			bool verify = false;
			verify = true;
			#endregion

			#region String
			string text = @"Ygor Carvalho\n 2003 @@??$$";
			string message = null;
			message = text;
			#endregion

			#region Var
			var value = 100;
			value = 44;
			value = "Ygor";
			#endregion

			#region Object
			object obj = false;
			obj = 200;
			obj = "Ygor";
			#endregion

			#region Const
            const double pi = 3.1415;
            const string name = "Ygor";
			#endregion

			#region Enum
            Grades studentGrade = Grades.Average;
			#endregion

			#region Structure
            Person p1 = new Person();
            p1.height = 1.70;
            p1.age = 20;
            p1.name = "Ygor";

            Person p2 = new Person()
			{
                name = "Leonardo",
                age = "22",
                height = "1.80"
			};
			#endregion

			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
