using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Singleton
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        private Singleton()
        {
            Id = 0;
            Name = string.Empty;
            Description = string.Empty;
            Price=0;
        }
        static Singleton obj=new Singleton();
        public static Singleton CreateObject()
        { 
            if(obj == null) {
                obj= new Singleton();
            }
            return obj;
        }
    }
}
