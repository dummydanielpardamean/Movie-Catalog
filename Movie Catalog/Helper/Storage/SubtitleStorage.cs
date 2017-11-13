using System;
using System.IO;
using System.Windows.Forms;

namespace Movie_Catalog.Helper.Storage
{
    class SubtitleStorage : Storage
    {
        private String DestPath = Application.StartupPath + @"\..\..\Resources\Movies\";

        private String FilePath, UniqueName;

        public SubtitleStorage(String UniqueName, String FilePath)
        {
            Dir.CreateIfDirectoryNotExist(DestPath);

            this.FilePath = FilePath;
            this.UniqueName = UniqueName;
        }

        public void Run()
        {
            base.Run(
                    FilePath,
                    Path.Combine(
                        DestPath, 
                        String.Format("{0}{1}",UniqueName, Path.GetExtension(FilePath))
                    )
                );
        }

        public string GetName()
        {
            return String.Format("{0}.{1}",
                    this.UniqueName,
                    Path.GetExtension(this.FilePath)
                );
        }
    }
}
