using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "ApplicationJurisdiction")]
    public class ApplicationJurisdiction
    {

        [XmlAttribute(AttributeName = "tc")]
        public object Tc { get; set; }
    }
}
