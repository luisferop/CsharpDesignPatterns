using System.IO;

namespace prjSingleResponsibilityPrinciple
{
    //This class is the most appropriate for handling the responsibility of persisting Journal objects
    public class JournalPersistence
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, journal.ToString());
        }
    }
}
