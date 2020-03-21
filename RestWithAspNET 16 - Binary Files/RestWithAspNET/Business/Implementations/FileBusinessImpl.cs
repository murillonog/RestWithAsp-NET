using RestWithAspNET.Data.VO;
using System.IO;

namespace RestWithAspNET.Business.Implementations
{
    public class FileBusinessImpl : IFileBusiness
    {
        public byte[] GetPDFFile()
        {
            string path = Directory.GetCurrentDirectory();
            var fullPath = path + "\\Other\\aspnet-life-cycles-events.pdf";

            return File.ReadAllBytes(fullPath);
        }
    }
}
