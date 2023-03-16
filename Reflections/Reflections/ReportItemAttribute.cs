using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ReportItemAttribute: Attribute
    {
        public int ColOrder { get; set; }
        public string Heading { get; set; }
        public string Units { get; set; }
        public string Format { get; set; }
        public ReportItemAttribute(int ColOrder)
        {
            this.ColOrder = ColOrder;
        }
    }
}
