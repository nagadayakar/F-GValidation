using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "Producer")]
    public class Producer
    {

        [XmlElement(ElementName = "NIPRNumber")]
        public string NIPRNumber { get; set; }

        [XmlElement(ElementName = "CarrierAppointment")]
        //public CarrierAppointment CarrierAppointment { get; set; }

        [XmlElement(ElementName = "OLifEExtension")]
        public OLifEExtension OLifEExtension { get; set; }
    }
}
