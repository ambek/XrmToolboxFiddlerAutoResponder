using System;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace FiddlerAutoResponder
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Fiddler AutoResponder Generator"),
        ExportMetadata("Description", "Generates Fiddler AutoResponder Rules for Dynamics CRM. Select folder for js and ts and import rules to Fiddler."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", null),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}