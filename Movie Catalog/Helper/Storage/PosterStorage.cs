using System;
using System.IO;
using System.Windows.Forms;

namespace Movie_Catalog.Helper.Storage
{
    class PosterStorage : Storage
    {
        private PictureBox PictureBox;

        private static String DestPath = Application.StartupPath + @"\..\..\Resources\Posters\";

        private String UniqueName, FileName;

        public PosterStorage(String uniqueName, PictureBox picture)
        {
            Dir.CreateIfDirectoryNotExist(DestPath);

            PictureBox = picture;
            UniqueName = uniqueName;
        }

        public PosterStorage(String fileName)
        {
            FileName = Path.Combine(DestPath, fileName);
        }

        public void Run()
        {
            base.Run(
                    PictureBox, 
                    Path.Combine(DestPath, FileName)
                );
        }

        public void Delete()
        {
            base.Delete(FileName);
        }

        public String GetName()
        {
            return FileName = String.Format("{0}.{1}", UniqueName, "jpg");
        }

        public static String GetFile(String PosterPath)
        {
            return Path.Combine(DestPath, PosterPath);
        }
    }
}
