using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCLStorage;
using System.IO;
using System.Xml;

namespace uk.co.mbend.archeryscorecard
{
    class SaveToFile
    {

        public struct ArcherFileName
        {
            public bool saveSucceeded;
            public string Filename;
        }


        public async Task<ArcherFileName> NewXMLFile(string ArcherFirstName, string ArcherSecondName, string ArcherGender, DateTime ArcherDOB, String ArcherBowstyle)
        {
            ArcherFileName RetVal;

            IFolder rootfolder = FileSystem.Current.LocalStorage;
            IFolder appdirfolder = await rootfolder.CreateFolderAsync("ArcheryScoreCard", CreationCollisionOption.OpenIfExists);


            string filename = string.Concat(ArcherFirstName[1], ArcherSecondName, "_ScoreDB.xml");


            ExistenceCheckResult ArcherDataFileExists = await appdirfolder.CheckExistsAsync(filename);

            switch(ArcherDataFileExists)
            {
                case ExistenceCheckResult.FileExists:
                    //Check that the file has the same details as we're about to give it. If not, add a second file next to it
                    IFile ArcherDB = await appdirfolder.GetFileAsync(filename);
                    bool ArcherFileAlreadyExistsAndIsCorrect = false;



                    if(ArcherFileAlreadyExistsAndIsCorrect)
                    {
                        //Pass sucess to the calling function
                        RetVal.saveSucceeded = true;
                        RetVal.Filename = filename;
                    }
                    else
                    {

                        filename = string.Concat(ArcherFirstName[1], ArcherSecondName, "_ScoreDB.xml");
                        RetVal.saveSucceeded = true;
                        RetVal.Filename = filename;
                    }
                    break;

                case ExistenceCheckResult.NotFound:
                    //Create new file


                    RetVal.saveSucceeded = true;
                    RetVal.Filename = filename;
                    break;

                default:
                case ExistenceCheckResult.FolderExists:
                    //There shoudn't be a folder here under this name
                    RetVal.saveSucceeded = false;
                    RetVal.Filename = null;
                    break;
            }

            return RetVal;
        }

        public ArcherFileName AppendNewRound(string RoundCustomName, int NohalfDozens, string RoundType, DateTime RoundDate, Array ArrowVals)
        {
            ArcherFileName RetVal;


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
