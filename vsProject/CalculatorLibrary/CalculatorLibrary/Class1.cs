using System.Collections.Generic;

namespace CalculatorLibrary
{
    public class Resistor
    {
        int RingCount, TempK;
        double Resistance, Tolerance;
        string[] Rings;
        //Ring1, Ring2, Ring3, Ring4, Ring5, Ring6;
        private readonly Dictionary<string, double> multiptiplicatorsMap = new Dictionary<string, double>() {
                    { "Чорний", 1},
                    { "Коричневий", 10},
                    { "Червоний", 100},
                    { "Помаранчевий", 1000},
                    { "Жовтий", 10000},
                    { "Зелений", 100000},
                    { "Синій", 1000000},
                    { "Фіолетовий", 10000000},
                    { "Золотий", 0.1},
                    { "Срібний", 0.01},
        };
        private readonly Dictionary<string, int> colorsToNumberMap = new Dictionary<string, int>() {
                    { "Чорний", 0},
                    { "Коричневий", 1},
                    { "Червоний", 2},
                    { "Помаранчевий", 3},
                    { "Жовтий", 4},
                    { "Зелений", 5},
                    { "Синій", 6},
                    { "Фіолетовий", 7},
                    { "Сірий", 8},
                    { "Білий", 9},
        };
        private readonly Dictionary<string, double> colorsToTolaranceMap = new Dictionary<string, double>() {
                    { "Коричневий", 1},
                    { "Червоний", 2},
                    { "Зелений", 0.5},
                    { "Синій", 0.25},
                    { "Фіолетовий", 0.1},
                    { "Золотий", 5},
                    { "Срібний", 10},
        };
        private readonly Dictionary<string, int> colorsToTempKMap = new Dictionary<string, int>() {
                    { "Чорний", 0},
                    { "Коричневий", 100},
                    { "Червоний", 50},
                    { "Помаранчевий", 15},
                    { "Жовтий", 25},
                    { "Синій", 10},
                    { "Фіолетовий", 5},
                    { "Білий", 1},
        };

        public Resistor(int RignCount, string[] Rings)
        {
            RingCount = RignCount;
            this.Rings = Rings;
        }

        public void CalculateResistance()
        {
            switch (RingCount)
            {
                case 3:
                    {
                        double multiplicator = GetMultiplierByColor(RingColor(3));
                        double ring1 = Value(RingColor(1));
                        double ring2 = Value(RingColor(2));

                        string ringsValue = Convert.ToString(ring1) + Convert.ToString(ring2);

                        Resistance = Convert.ToInt32(ringsValue) * multiplicator;
                        break;
                    }
                case 4:
                    {
                        double multiplicator = GetMultiplierByColor(RingColor(3));
                        double ring1 = Value(RingColor(1));
                        double ring2 = Value(RingColor(2));

                        string ringsValue = Convert.ToString(ring1) + Convert.ToString(ring2);

                        Resistance = Convert.ToInt32(ringsValue) * multiplicator;
                        Tolerance = GetToleranceByColor(RingColor(4));
                        break;
                    }
                case 5:
                    {
                        double multiplicator = GetMultiplierByColor(RingColor(4));
                        double ring1 = Value(RingColor(1));
                        double ring2 = Value(RingColor(2));
                        double ring3 = Value(RingColor(3));

                        string ringsValue = Convert.ToString(ring1) + Convert.ToString(ring2) + Convert.ToString(ring3);

                        Resistance = Convert.ToInt32(ringsValue) * multiplicator;
                        Tolerance = GetToleranceByColor(RingColor(5));
                        break;
                    }
                case 6:
                    {
                        double multiplicator = GetMultiplierByColor(RingColor(4));
                        double ring1 = Value(RingColor(1));
                        double ring2 = Value(RingColor(2));
                        double ring3 = Value(RingColor(3));
                        string ringsValue = Convert.ToString(ring1) + Convert.ToString(ring2) + Convert.ToString(ring3);

                        Resistance = Convert.ToInt32(ringsValue) * multiplicator;
                        Tolerance = GetToleranceByColor(RingColor(5));
                        TempK = GetTempKByColor(RingColor(6));
                        break;
                    }
            }
        }

        public double GetMultiplierByColor(string color)
        {
            return multiptiplicatorsMap[color];
        }

        public double GetToleranceByColor(string color)
        {
            return colorsToTolaranceMap[color];
        }
        public int GetTempKByColor(string color)
        {
            return colorsToTempKMap[color];
        }
        public string RingColor(int position)
        {
            return Rings[position - 1];
        }
        public int Value(string color)
        {
            return colorsToNumberMap[color];
        }

        public double GetResistance()
        {
            return Resistance;
        }
        public double GetTolerance()
        {
            return Tolerance;
        }
        public int GetTempK()
        {
            return TempK;
        }
    }
}