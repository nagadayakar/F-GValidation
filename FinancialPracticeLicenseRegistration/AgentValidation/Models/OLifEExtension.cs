using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "OLifEExtension")]
    public class OLifEExtension
    {

        [XmlElement(ElementName = "LegalEntityCode")]
        public string LegalEntityCode { get; set; }

        [XmlElement(ElementName = "DetachedOfficeCode")]
        public object DetachedOfficeCode { get; set; }
    }
}
