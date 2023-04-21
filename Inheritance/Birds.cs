using System;
namespace Inheritance
{
	public class Birds : Animal
	{
		public Birds()
		{
            CanBreath = true;
            IsBorn = true;
            HasLegs = 2;
            Eats = true;


		}

        public bool CanFly { get; set; }
        public bool  HasWings { get; set; }
        public bool DoesMigrate { get; set; }
        public bool HasBeak { get; set; }

    }
}

