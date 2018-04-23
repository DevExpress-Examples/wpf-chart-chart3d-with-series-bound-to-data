namespace GettingStarted2 {
    public class Star {
        public int HipID { get; private set; }
        public string Spectr { get; private set; }
        public double Luminocity { get; private set; }
        public double ColorIndex { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Star(
                int id,
                double x,
                double y,
                double z,
                string spectr, 
                double luminocity, 
                double colorIndex
        ) {
            HipID = id;
            X = x;
            Y = y;
            Z = z;
            Spectr = spectr;
            Luminocity = luminocity;
            ColorIndex = colorIndex;
        }
    }
}