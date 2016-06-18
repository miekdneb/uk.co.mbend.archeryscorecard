/*using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using uk.co.mbend.archeryscorecard.Windows;
using Xamarin.Forms;
using PCLStorage;
using Windows.Storage;
using System.Xml.Serialization;

[assembly: Xamarin.Forms.Dependency(typeof(uk.co.mbend.archeryscorecard.Windows.SaveToFile_Windows))]

namespace uk.co.mbend.archeryscorecard.Windows
{
    class SaveToFile_Windows : ISaveToFile
    {

        public SaveToFile_Windows() { }

        public FileName NewXMLFile(string ArcherFirstName, string ArcherSecondName, string ArcherGender, DateTime ArcherDOB, String ArcherBowstyle)
        {
            FileName RetVal;

            string filename = string.Concat(ArcherFirstName[1], ArcherSecondName, "_ScoreDB.xml");
            string filepath = Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);

            var Datafile = FileSystem.Current.GetFileFromPathAsync(filepath);

            if(Datafile != null)
            {
                RetVal.saveSucceeded = true;
                RetVal.Filename = filename;
            }
            else
            {
                /*StreamWriter xmlwriter = null;

                try
                {
                    var serialiser = new XmlSerializer(typeof(string));
                    xmlwriter = new StreamWriter(filepath,true, Encoding.UTF8)
                    serialiser.Serialize(xmlwriter, ArcherFirstName);

                }
                finally
                {
                    if(xmlwriter != null)
                    {
                        xmlwriter.Close()
                    }
                }*
            }



            return RetVal;
        }
        public FileName AppendNewRound(string RoundCustomName, int NohalfDozens, string RoundType, DateTime RoundDate, Array ArrowVals)
        {
            FileName RetVal;


            RetVal.saveSucceeded = true;
            RetVal.Filename = "MyFile.xml";

            return RetVal;
        } 

        public bool ReadArcherResults(string Filename)
        {
            return true; 
        }
    }
}
*/