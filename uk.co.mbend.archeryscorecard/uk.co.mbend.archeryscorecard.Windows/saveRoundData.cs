/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace uk.co.mbend.archeryscorecard
{
    class saveRoundData
    {

        String filename;

        public int NewXMLDatabase(String ArcherName, bool isOutdoor)
        {

            if (isOutdoor)
            {
                filename = String.Concat(ArcherName, "_Outdoor_Rounds");
            }
            else
            {
                filename = String.Concat(ArcherName, "_Indoor_Rounds");
            }

            var documents = System.Environment.GetFolderPath();

            

            string filePath = Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.Personal), "MyFile.txt");
            System.IO.File.WriteAllText(filePath, "Contents of text file");
            Console.WriteLine(System.IO.ReadAllText(filePath));

            return 1;
        }
    }
}*/
