using System;
namespace ResponsiPemrograman2689
 

{
class Karyawan
{
	public int nik { get; set;}
	public string nama { get; set;}
	public int gaji {get; set;}
	public int gajinaik {get; set;}


	
  public Karyawan(int NIK, string NAMA, int gajibiasa)
  {
		nik = NIK;
		nama = NAMA;
		gaji = gajibiasa;
    gajinaik = 10;

		if ( gajibiasa < 0)
    {
			gaji = 0;
		}
	}

  public void getdapetbonus()
  {
		    int bonus = gaji/ gajinaik;
        gaji = gaji + bonus;
        Console.WriteLine("{0}  \t{1}\t\t\t {2}", nik, nama, gaji);
	}
	
  
  
  public void PrintAndShow()
  {
		Console.WriteLine("{0}  \t{1}\t\t\t {2}", nik, nama, gaji);
	}

	
  
  public class MainProgram
  {
		static void Main(String[] args)
    {
			Console.WriteLine("NIK\t\t\t Nama \t\t\t Gaji");
			Console.WriteLine("-------------------------------------------------");
		
    Karyawan karyawan1 = new Karyawan(19112689, "David", 2000000);
		Karyawan karyawan2 = new Karyawan(19112688, "Nizam", 300000);

			
      karyawan1.PrintAndShow();
			karyawan2.PrintAndShow();

			Console.WriteLine("\n\n Selamat kalian Dapat Kenaikan Gaji 10% :)");
			Console.WriteLine("\n\nNIK\t\t\t Nama \t\t\t Gaji");
			Console.WriteLine("-------------------------------------------------");
			
            
            karyawan1.getdapetbonus();
            karyawan2.getdapetbonus();

			
		}
	}
}
}   