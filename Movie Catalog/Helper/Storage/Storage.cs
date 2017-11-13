using System;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Movie_Catalog.Helper.Storage
{
    class Storage
    {
        // Thread untuk movie dan subtitle
        protected void Run(String FilePath, String DestPath)
        {
            Thread thread = new Thread(
                    new ThreadStart( () =>
                    {
                        try
                        {
                            File.Copy(FilePath, DestPath);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    })
                );

            thread.Start();
            thread.Join();
        }

        // Thread untuk poster movie
        protected void Run(PictureBox pictureBox, String DestPath)
        {
            Thread thread = new Thread(
                    new ThreadStart( () => pictureBox.Image.Save(DestPath, ImageFormat.Jpeg))
                );

            thread.Start();
            thread.Join();
        }
    }
}
