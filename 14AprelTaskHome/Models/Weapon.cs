using _14AprelTaskHome.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14AprelTaskHome.Models
{
    internal class Weapon
    {
        private static int _id;
        public int Id { get; set; }
        public BulletType BulletType { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }

        public Stack<Bullet> Bullets { get; }= new Stack<Bullet>();
        public Weapon(string name,int capacity,BulletType bullettype)
        {
            _id++;
            Id = _id;
            Name = name;
            BulletType = bullettype;
            Capacity = capacity; 
        }
        public (int count, BulletType bullettype) Fire()
        {
            Bullets.Pop();
            return (Bullets.Count, BulletType);
        }
        public Bullet PulTiger()
        { 
            return Bullets.Peek();
        }
        public void Fill()
        {
            if (Capacity == Bullets.Count)
            {
                throw new Exception("Capacity doludur");
            }
            for(int i = 0; i < Capacity-Bullets.Count; i++) 
            {
                Bullets.Push(new Bullet(BulletType));
            }


        }
    }
}
