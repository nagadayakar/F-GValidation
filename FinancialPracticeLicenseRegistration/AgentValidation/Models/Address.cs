using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgentValidation.Models
{

    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(TXLife));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (TXLife)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "Address")]
    public class Address
    {
        [XmlElement(ElementName = "AddressStateTC")]
        public AddressStateTC AddressStateTC { get; set; }
    }
}
