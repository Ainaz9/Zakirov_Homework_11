
namespace Tumakov
{
    class Buildings
    {
        private List<Building> ListBuildings;

        public Buildings()
        {
            ListBuildings = new List<Building>(10);
        }

        public Building this[int index]
        {
            get
            {
                if (index < 0 || index > ListBuildings.Count)
                {
                    throw new Exception("Индекс больше кол-во здании");
                }
                else
                {
                    return ListBuildings[index];
                }
            }
            set
            {
                if (index < 0 || index > ListBuildings.Count)
                {
                    throw new Exception("Индекс больше кол-во здании");
                }
                else
                {
                    ListBuildings[index] = value;
                }
            }
        }

        public void AddBuilding(Building building)
        {
            ListBuildings.Add(building);
        }
    }
}
