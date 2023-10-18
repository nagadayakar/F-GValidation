using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "TXLife")]
    public class TXLife
    {

        [XmlElement(ElementName = "UserAuthRequest")]
        public UserAuthRequest UserAuthRequest { get; set; }

        //[XmlElement(ElementName = "TXLifeRequest")]
        //public TXLifeRequest TXLifeRequest { get; set; }

        //[XmlAttribute(AttributeName = "ns")]
        //public string Ns { get; set; }

        //[XmlText]
        //public string Text { get; set; }
    }
}
