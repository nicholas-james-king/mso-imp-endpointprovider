using System;
using System.Collections.Generic;
using System.Text;

namespace iress.mso.endpointprovider.components.Pocos
{
    public class Endpoint
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string URI { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
