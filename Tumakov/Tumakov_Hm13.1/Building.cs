
namespace Tumakov
{
    class Building
    {
        private int IdStat { get; set; }
        private int Id { get; set; }
        private float Height { get; set; }
        private int NumberOfStoreys { get; set; } // Кол-во этажей
        private int NumberOfApartaments { get; set; } // Кол-во квартир
        private int NumberOfEntrances { get; set; } // Кол-во подъездов

        public Building(float height, int numberOfStoreys, int numberOfApartaments, int numberOfEntrances)
        {
            GenerateId();
            Height = height;
            NumberOfStoreys = numberOfStoreys;
            NumberOfApartaments = numberOfApartaments;
            NumberOfEntrances = numberOfEntrances;
        }
        public int GenerateId()
        {
            IdStat++;
            Id = IdStat;
            return Id;
        }

        public float FloorHeight()
        {
            return Height / NumberOfStoreys;
        }

        public int NumberOfApartmentsInTheEntrance()
        {
            return NumberOfApartaments / NumberOfEntrances;
        }

        public int NumberOfApartmentsPerFloor()
        {
            return NumberOfApartaments / NumberOfStoreys;
        }

        public override string ToString()
        {
            return $"Номер здание: {Id} | " +
                   $"Высота здания: {Height} | " +
                   $"Кол-во этажов: {NumberOfStoreys} | " +
                   $"Кол-во квартир: {NumberOfApartaments} | " +
                   $"Кол-во подъездов: {NumberOfEntrances} | ";
        }
    }
}
