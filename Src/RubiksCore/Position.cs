namespace RubiksCore
{
    public struct Position
    {
        public int X
        {
            get;
            set;
        }
        
        public int Y
        {
            get;
            set;
        }

        public int Z
        {
            get;
            set;
        }

        public Position(int x, int y, int z)
            :this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X, Y, Z);
        }
    }
}
