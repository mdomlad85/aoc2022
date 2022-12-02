using System.IO;
using System.Threading.Tasks;

namespace SharedKernel.Input
{

    public class FileReadInput : IReadInput
    {
        private static FileReadInput _instance;

        public static FileReadInput GetInstance()
        {
            return _instance ??= new FileReadInput();
        }

        private string _path;

        private FileReadInput()
        {
            _path = @"../../../Data/input.txt";
        }

        public Task<string[]> LoadAsync(string path = "")
        {
            if (!string.IsNullOrEmpty(path)) _path = path;
            return File.ReadAllLinesAsync(_path);
        }

        public string[] Load(string path = "")
        {
            if (!string.IsNullOrEmpty(path)) _path = path;
            return File.ReadAllLines(_path);
        }
    }
}