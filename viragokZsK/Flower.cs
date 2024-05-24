using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viragokZsK
{
	internal class Flower
	{
		public string Name { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
		public string Img { get; set; }

		public Flower(string sorok) 
		{
			var sor = sorok.Split(";");
			Name = sor[0];
			Price = int.Parse(sor[1]);
			Color = sor[2];
			Img = sor[3];
		}
    }
}
