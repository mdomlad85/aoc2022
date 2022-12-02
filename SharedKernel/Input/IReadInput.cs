using System.Threading.Tasks;

namespace SharedKernel.Input
{

    public interface IReadInput
    {
        public Task<string[]> LoadAsync(string path = "");
        public string[] Load(string path = "");
    }
}