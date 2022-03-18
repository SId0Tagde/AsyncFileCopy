// See https://aka.ms/new-console-template for more information
namespace AsyncFileCopy
{
        public class Program{
        static async Task Main(string[] args)
        {   
            Console.WriteLine("Copying file \"Read.txt\" asynchronously ");
            await asyncCopyFile();  
            Console.WriteLine($"Copied file \"Read.txt\" asynchronously to \"Write.txt\" in {Path.GetFullPath("\\AsyncFilecopy\\src\\asyncFilecopy\\Write.txt")}");          
        }

        private static async Task asyncCopyFile()
        {   
            var data = await readFile("Read.txt");
            await writetoFile("Write.txt", data.AsEnumerable());
        }

        private static  Task<string[]> readFile(string file)
        {
            var data =  File.ReadAllLinesAsync(file);    
            return data;
        }
        private static async  Task writetoFile(string file, IEnumerable<string> data)
        {
            await File.WriteAllLinesAsync(file,data);
        }
    }   
}

