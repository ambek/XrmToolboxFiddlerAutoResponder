using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FiddlerAutoResponder.Model
{
    [XmlRoot]
    public class AutoResponder
    {
        public AutoResponder()
        {
            State = new FiddlerState();
        }

        [XmlElement]
        public FiddlerState State { get; set; }
    }


    public class FiddlerState
    {
        public FiddlerState()
        {
            Enabled = true;
            Fallthrough = true;
            UseLatency = false;
        }
        [XmlAttribute]
        public bool Enabled { get; set; }

        [XmlAttribute]
        public bool Fallthrough { get; set; }

        [XmlAttribute]
        public bool UseLatency { get; set; }

        [XmlElement]
        public List<Rule> ResponseRule { get; set; }
    }

    public class Rule
    {
        public Rule()
        { }
        public Rule(string match, string action, bool enabled = true)
        {
            Match = match;
            Action = action;
            Enabled = enabled;
        }
        [XmlAttribute]
        public string Match { get; set; }
        [XmlAttribute]
        public string Action { get; set; }
        [XmlAttribute]
        public bool Enabled { get; set; }
    }
}
