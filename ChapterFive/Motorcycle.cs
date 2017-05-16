namespace ChapterFive
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;

        public static string company;

        static Motorcycle()
        {
            company = "Jacob";
        }

        public Motorcycle(int intensity = 10, string name = "Jacob")
        {
            this.driverIntensity = intensity;
            this.name = name;
        }

        public void SetDriverName(string name)
        {
            this.name = name;
            //company = "J";
        }

        public static void SetCompany(string name)
        {
            company = name;
        }
    }
}
