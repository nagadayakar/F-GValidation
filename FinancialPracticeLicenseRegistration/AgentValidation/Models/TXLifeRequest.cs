using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "TXLifeRequest")]
    public class TXLifeRequest
    {

        [XmlElement(ElementName = "TransRefGUID")]
        public string TransRefGUID { get; set; }

        [XmlElement(ElementName = "TransType")]
        public TransType TransType { get; set; }

        [XmlElement(ElementName = "TransSubType")]
        public TransSubType TransSubType { get; set; }

        [XmlElement(ElementName = "TransExeDate")]
        public DateTime TransExeDate { get; set; }

        [XmlElement(ElementName = "TransExeTime")]
        public DateTime TransExeTime { get; set; }

        [XmlElement(ElementName = "OLifE")]
        public OLifE OLifE { get; set; }
    }
}
