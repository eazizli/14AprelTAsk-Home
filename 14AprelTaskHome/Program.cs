using _14AprelTaskHome.Enums;
using _14AprelTaskHome.Models;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
       // Weapon weapon;
        Bullet bullet;
        List<Weapon> weapons= new List<Weapon>();
        List<Bullet> bullets;
        Console.WriteLine("1.Creat Weapon");
        Console.WriteLine("2.Remove Weapon");
        Console.WriteLine("3.Get Weapon ");
        Console.WriteLine("4.Get Weapon");
        Console.WriteLine("5.Select Weapon");
        List<Weapon> weapons1= new List<Weapon>();

        for (; ; )
        {
        string click =Console.ReadLine();

           
            if (click == "1")
            {
                Console.WriteLine("Weapon name");
                string name = Console.ReadLine();

                Console.WriteLine("Weapon Type");
                BulletType bulletType=BulletType.Parse(Console.ReadLine());
                Console.WriteLine("Weapon Capacity");
                int capacity = int.Parse(Console.ReadLine());
                Weapon weapon=new Weapon(name,capacity,bulletType);
                
                Console.WriteLine("----Weapon Created----");

                
               
            }
            if (click == "2")
            {
                Console.WriteLine("Remove Weapon");
                int Id = int.Parse(Console.ReadLine());
                Weapon weaponRemove = weapons.Find(x => x.Id == Id);
                if (weaponRemove != null)
                {
                    foreach (Weapon item in weapons)
                    {

                        weapons.Remove(weaponRemove);
                    }
                }
                else { Console.WriteLine("Bele ID - li weapon yoxdur"); }
            }
            if (click == "3")
            {
                Console.WriteLine("Get Weapon by Capacity");
                int Capacity = int.Parse(Console.ReadLine());
               
                Weapon weaponCapacite=weapons1.Find(x => x.Capacity > Capacity);



            }
            if(click == "4") 
            {
                Console.WriteLine(weapons.Count);
            }


          
        }




    }
}