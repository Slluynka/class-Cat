namespace Lab5
{ 
    public enum Gender
    {
        Male,
        Female
    }
class Cat
    {
        public string Name { get; }
        public Gender Gender { get; }
        private double _energy;
        public double Energy
        {
            get { return _energy; } // get method
            private set
            {   //Перевіряємо чи достатня енергія для стрибка.
                if (value < MinEnergy)
                    //Console.WriteLine("Not enough energy to jump");
                    throw new InvalidOperationException("Not enough energy to jump");
                else if (value > MaxEnergy)
                    _energy = MaxEnergy;
                else 
                    _energy = value;
            } // set method
        }
        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;

        //Конструктор
        public Cat (string name, Gender gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy;
        }
        //Методи
        public void Jump()
        {
            Energy = Energy - JumpEnergyDrain;
        }
        public void Sleep()
        {
            Energy = Energy + SleepEnergyGain;
        }
        static void Main()
        {
            Cat cat1 = new Cat("Snizhok", 0);
            Console.WriteLine(cat1.Gender);
            cat1.Jump();
            Console.WriteLine(cat1.Energy);
            cat1.Sleep();
            Console.WriteLine(cat1.Energy);
        }
    }

    
}