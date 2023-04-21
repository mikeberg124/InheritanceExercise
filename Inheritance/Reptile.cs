using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
            CanBreath = true;
            IsBorn = true;
            HasLegs = 4;
            Eats = true;

        }
        public bool IsColdBlooded { get; set; }
        public bool CanGrowLimbs { get; set; }
        public string Eyecolor { get; set; }
        public bool HasScales { get; set; }


    }
}

