namespace Builder.Domain
{
    public class Car
    {
        public Car(int doors, int zylinders, string brand, int yearBuild, int monthBuild, bool hasAirbag,
            string carType, int dayBuild, bool hasAirConditioning)
        {
            Doors = doors;
            Zylinders = zylinders;
            Brand = brand;
            YearBuild = yearBuild;
            MonthBuild = monthBuild;
            HasAirbag = hasAirbag;
            CarType = carType;
            DayBuild = dayBuild;
            HasAirConditioning = hasAirConditioning;
        }

        public int Doors { get; }
        public int Zylinders { get; }
        public string Brand { get; }
        public int YearBuild { get; }
        public int MonthBuild { get; }
        public bool HasAirbag { get; }
        public string CarType { get; }
        public int DayBuild { get; }
        public bool HasAirConditioning { get; }
    }
}