using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NistModel
    {
        public string id { get; set; }
        // id
        public string cisaRequiredAction { get; set; }
        // cisarequiredaction
        public decimal value { get; set; }
        // description (value)
        public string accessComplexity { get; set; }
        // accesscomplexity
        public string baseSeverity { get; set; }
        // baseseverity
        public string exploitabilityScore { get; set; }
        // exploitabilityscore
        public string impactScore { get; set; }
        // impactscore
    }
}
