using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "Relation")]
    public class Relation
    {
        [XmlElement(ElementName = "OriginatingObjectType")]
        public OriginatingObjectType OriginatingObjectType { get; set; }

        [XmlElement(ElementName = "RelatedObjectType")]
        public RelatedObjectType RelatedObjectType { get; set; }

        [XmlElement(ElementName = "RelationRoleCode")]
        public RelationRoleCode RelationRoleCode { get; set; }

        [XmlElement(ElementName = "InterestPercent")]
        public int InterestPercent { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "OriginatingObjectID")]
        public string OriginatingObjectID { get; set; }

        [XmlAttribute(AttributeName = "RelatedObjectID")]
        public string RelatedObjectID { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
