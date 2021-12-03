using System;

namespace Check_Prima
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, angka, hitung, hasil;
			Console.Write("Masukkan Angka : ");
			angka = Convert.ToInt32(Console.ReadLine());
			hitung = 0;
			for (i = 1; i <= angka; i++)
			{
				hasil = angka % i;
				if (hasil == 0)
				hitung = hitung + 1;
			}
			if (hitung == 2)
				Console.WriteLine(angka + " adalah bilangan prima");
			else
				Console.WriteLine(angka + " adalah bilangan bukan prima");
		}
	}
}
