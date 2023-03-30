using System.Collections.Generic;

namespace AutoKaMapper.Models
{
  
        public class fleet
        {
            public List<string> Name{ get; set; }
            public List<int> PmoId { get; set; }
            public List<string> SKU { get; set; }
        }

        public class printerProduct
        {
            public string Name { get; set; }
            public int PmoId { get; set; }
            public string SKU { get; set; }
        }

    
}
