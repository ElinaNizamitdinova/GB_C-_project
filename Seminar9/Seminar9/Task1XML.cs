using Seminar9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Seminar9
{

    //[XmlRoot("Data.Root")]
    //public class DataRoot
    //{
    //    [XmlArray("Data.Root.Names")]
    //    [XmlArrayItem("Name")]
    //    public string[] Names;

    //    [XmlElement(typeof(DataEntry))]
    //    [XmlElement(typeof(DataX))]
    //    public DataEntry[] Entry;
    //    //[XmlElement(typeof(DataX))]
    //    //public DataX X;


    //}
    //[XmlType("Data.Entry")]
    //public class DataEntry
    //{
    //    [XmlAttribute]
    //    public string LinkedEntry;
    //    [XmlElement("Data.Nmae")]
    //    public string Name;
    //}

    //[XmlType("Data#ExtendedEntry")]
    //public class DataX : DataEntry
    //{
    //    //[XmlElement("Data.Name")]
    //    //public string Name;
    //    [XmlElement("Data#Extended")]
    //    public string DataExt;
    //}

    //internal class Task1XML
    //{
    //    static void Main(string[] args)
    //    {

    //        var xml = """
    //            <?xml version = "1.0" encoding ="utf-8"?>
    //            <Data.Root xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd ="http://www.w3.org/2001/XMLSchema">
    //              <Data.Root.Namess>
    //                <Name>Name1</Name>
    //                <Name>Name2</Name>
    //                <Name>Name3</Name>
    //               </Data.Root.Namess>

    //               <Data.Entry LinkedEntry="Name1">
    //                 <Data.Name> Name2</Data.Name>
    //               </Data.Entry>

    //               <Data_x0023_ExtendedEntry LinkedEntry="Name2">
    //                 <Data.Name> Name1</Data.Name>
    //                 <Data_x0023_Extended> NameOne</Data_x0023_Extended>
    //               </Data_x0023_ExtendedEntry>
    //            </Data.Root>
    //            """;


    //        DataRoot dataRoot = new DataRoot();
    //        dataRoot.Names = new string[] { "Name1", "Name2", "Name3" };


    //        dataRoot.Entry = new DataEntry[2];
    //        dataRoot.Entry[0] = new DataEntry();
    //        dataRoot.Entry[0].LinkedEntry = "Name1";
    //        dataRoot.Entry[0].Name = "Name2";

    //        dataRoot.Entry[1] = new DataX { LinkedEntry = "Name2", Name = "Name1", DataExt = "NamwOne" };

    //        var seriolaze = new XmlSerializer(typeof(DataRoot));
    //        seriolaze.Serialize(Console.Out, dataRoot);


    //    }
    //}
}
