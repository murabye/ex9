namespace ex9
{
    class Point
    {
        public Point Next { get; set; }
        public string Info { get; set; }

        public Point()
        {
            Info = "";
            Next = null;
        }
        public Point(string info)
        {
            Info = info;
        }

        public override string ToString()
        {
            var res = Info;
            var cur = this;

            while (cur.Next != null)
            {
                res += " " + cur.Next.Info;
                cur = cur.Next;
            }

            return res;
        }
    }
}
