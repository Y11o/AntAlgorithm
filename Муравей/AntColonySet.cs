namespace Муравей
{
    class AntColonySet
    {
        private int countAnt = 0;
        private double vaporSpeed = 0d;
        private double pheromon = 0d;
        private int countIter = 0;
        private double alpha = 0;
        private double beta = 0;

        public int CountAnt { get => countAnt; set => countAnt = value; }
        public double VaporSpeed { get => vaporSpeed; set => vaporSpeed = value; }
        public double Pheromon { get => pheromon; set => pheromon = value; }
        public int CountIter { get => countIter; set => countIter = value; }
        public double Alpha { get => alpha; set => alpha = value; }
        public double Beta { get => beta; set => beta = value; }

        public bool checkSettings()
        {

            if (countAnt == 0 || vaporSpeed == 0 || pheromon == 0 || countIter == 0 || alpha == 0 || beta == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
