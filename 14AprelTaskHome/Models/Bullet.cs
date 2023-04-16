using _14AprelTaskHome.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14AprelTaskHome.Models
{
    internal class Bullet
    {
        private static int _id;
        public int Id { get; set; }
        public BulletType BulletType { get; set; }

        public Bullet(BulletType bullettype)
        {
            _id++;
            Id = _id;
            BulletType=bullettype;
        }
    }
}
