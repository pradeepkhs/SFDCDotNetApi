using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDC.Canvas
{
    public class OrganizationContext
    {
        public string name { get; set; }
        public string organizationId { get; set; }
        public string namespacePrefix { get; set; }
        public bool multicurrencyEnabled { get; set; }
        public string currencyIsoCode { get; set; }
    }
}
