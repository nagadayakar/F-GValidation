using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "DistributionChannelInfo")]
    public class DistributionChannelInfo
    {

        [XmlElement(ElementName = "DistributionChannel")]
        public DistributionChannel DistributionChannel { get; set; }
    }
}
