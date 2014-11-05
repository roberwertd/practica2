
using System;

namespace pratica2
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Precio del primer producto");
			double product1 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del segundo producto");
			double product2 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del tercer producto");
			double product3 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del cuarto producto");
			double product4 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del quinto producto");
			double product5 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del sexto producto");
			double product6 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del septimo producto");
			double product7 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del octavo producto");
			double product8 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del noveno producto");
			double product9 = double.Parse(Console.ReadLine());
		
		
		    double producto1 = product1 * .16 + product1;
			
			double producto2 = product2 * .16 + product2;
			
			double producto3 = product3 * .16 + product3;
			
			double producto4 = product4 * .16 + product4;
			
			double producto5 = product5 * .16 + product5;
			
			double producto6 = product6 * .16 + product6;
			
			double producto7 = product7 * .16 + product7;
			
			double producto8 = product8 * .16 + product8;
			
			double producto9 = product9 * .16 + product9;
			
			Console.WriteLine("Precio del primero producto con IVA = " + producto1);
			Console.WriteLine("Precio del segundo producto con IVA = " + producto2);
			Console.WriteLine("Precio del tercer producto con IVA = " + producto3);		
			Console.WriteLine("Precio del cuarto producto con IVA = " + producto4);
			Console.WriteLine("Precio del quinto producto con IVA = " + producto5);
			Console.WriteLine("Precio del sexto producto con IVA = " + producto6);		
			Console.WriteLine("Precio del septimo producto con IVA = " + producto7);
			Console.WriteLine("Precio del octavo producto con IVA = " + producto8);
			Console.WriteLine("Precio del noveno producto con IVA = " + producto9);		
			
			double subtotal = producto1+producto2+producto3+producto4+producto5+producto6+producto7+producto8+producto9;
			double iva = 0.16 * subtotal;
			double total = subtotal + iva;
			
			
			
			Console.WriteLine(" Subtotal =" +subtotal);
			Console.WriteLine(" Iva =" + iva);
			Console.WriteLine(" Total =" + total);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}