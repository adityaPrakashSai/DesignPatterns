using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Order
    {
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }
}
