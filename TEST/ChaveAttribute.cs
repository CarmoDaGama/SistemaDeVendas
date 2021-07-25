using System;

namespace TEST
{
    public class ChaveAttribute : Attribute
    {
        public bool AutoIncremente { get; set; }
        public bool Unico { get; set; }
    }
}