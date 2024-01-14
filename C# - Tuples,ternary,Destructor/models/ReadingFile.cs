namespace CSharpTuples.models
{
    public class ReadingFile
    {
        public (bool sucess, string[] line, int linesQtd) ReadFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Count());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return (false, new string[0], 0);
            }
        }
    }
}