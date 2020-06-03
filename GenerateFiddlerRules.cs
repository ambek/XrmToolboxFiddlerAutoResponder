using FiddlerAutoResponder.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FiddlerAutoResponder
{
    public class StringWriterUTF8 : StringWriter
    {
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }

    public class FiddlerRulesGenerator
    {
        private List<string> Paths { get; set; }
        public FiddlerRulesGenerator(List<string> paths, string enviromentUrl)
        {
            Paths = paths;
        }

        public List<Rule> GenerateFiddlerRules()
        {

            var FiddlerRules = new List<Rule>();
            foreach (string path in Paths.Where(s => !string.IsNullOrEmpty(s)))
            {
                List<string> files = GetFilesFromPath(path);
                if (files == null || files.Count == 0)
                    continue;
                FiddlerRules.AddRange(GenerateRules(path, files));
            }
            return FiddlerRules;
        }
        
        public string SerializeToXML(List<Rule> FiddlerRules)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AutoResponder));
            var stringWriter = new StringWriterUTF8();
            AutoResponder fiddlerModel = new AutoResponder();
            fiddlerModel.State = new FiddlerState();
            fiddlerModel.State.ResponseRule = FiddlerRules;

            xmlSerializer.Serialize(stringWriter, fiddlerModel);
            return stringWriter.ToString();
        }


        private List<string> GetFilesFromPath(string path)
        {
            if (!Directory.Exists(path))
                return null;

            var files = new List<string>();
            files.AddRange(Directory.GetFiles(path, "*.*", SearchOption.AllDirectories));
            return files;
        }

        private List<Rule> GenerateRules(string path, List<string> files)
        {
            if (files == null || files.Count() < 1)
                return null;
            List<Rule> responseRules = new List<Rule>();
            foreach (var file in files)
            {
                string fileNameRel = file.Replace(path, "");
                fileNameRel = fileNameRel.Replace("\\", "/");
                Rule rule = new Rule($"(i)WebResources{fileNameRel}*", $"{file}");
                responseRules.Add(rule);
            }
            return responseRules;
        }
    }
}
