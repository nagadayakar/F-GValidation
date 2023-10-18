using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "TransSubType")]
    public class TransSubType
    {

        [XmlAttribute(AttributeName = "tc")]
        public int Tc { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
