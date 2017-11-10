using Movie_Catalog.Interfaces;
using System;
using System.IO;
using System.Windows.Forms;

namespace Movie_Catalog
{
    class Storage
    {
        // @ simbol berguna untuk escaping karakter.

        // Direktori untuk movie
        private string MovieDestinationPath = Application.StartupPath + @"\..\..\Resources\Movies\";

        // Direktori untuk poster movie.
        private string PosterDestinationPath = Application.StartupPath + @"\..\..\Resources\Posters\";

        // Direktori untuk subtitle movie
        private string SubtitleDestinationPath = Application.StartupPath + @"\..\..\Resources\Subtitle\";

        // Variabel untuk menyimpan uid, untuk penamaan unik pada file.
        private string uid;

        // path yang didapat dari openfiledialog.
        private string filePath;

        // menyimpan ekstensi file yang akan di upload.
        private string fileExtension;

        // menyimpan generate nama file untuk keperluan lain
        public string fileName;

        public Storage(string uid= "", string filePath = null, bool image=false)
        {
            // untuk kebutuhan setup.
            // pembuatan folder untuk penyimpanan jika folder belum tersedia.
            if (!Directory.Exists(MovieDestinationPath))
            {
                Directory.CreateDirectory(MovieDestinationPath);
            }

            if (!Directory.Exists(PosterDestinationPath))
            {
                Directory.CreateDirectory(PosterDestinationPath);
            }

            if (!Directory.Exists(SubtitleDestinationPath))
            {
                Directory.CreateDirectory(SubtitleDestinationPath);
            }

            this.uid = uid;

            if(filePath != null)
            {
                this.filePath = filePath;
                this.fileExtension = Path.GetExtension(this.filePath);
            }

            if (image)
                this.fileName = uid + ".jpg";
            else
                this.fileName = uid + fileExtension;
        }

        public void MoveMovie()
        {
            string DestinationPath = Path.Combine(MovieDestinationPath, fileName);

            try
            {
                File.Copy(this.filePath, DestinationPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void MoveSubtitle()
        {
            string DestinationPath = Path.Combine(MovieDestinationPath, fileName);
            try
            {
                File.Copy(this.filePath, DestinationPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void MoveImage(PictureBox pc)
        {
            string DestinationPath = Path.Combine(PosterDestinationPath, fileName);
            pc.Image.Save(DestinationPath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public string GetPoster(Movie movie)
        {
            return Path.Combine(PosterDestinationPath, movie.PosterPath);
        }

        public string GetMovie(string filename)
        {
            return Path.Combine(MovieDestinationPath, filename);
        }
    }
}
