using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "OLifE")]
    public class OLifE
    {

        [XmlElement(ElementName = "Holding")]
       // public Holding Holding { get; set; }

        [XmlElement(ElementName = "Party")]
        //public List<Party> Party { get; set; }

        [XmlElement(ElementName = "Relation")]
        public List<Relation> Relation { get; set; }
    }
}
