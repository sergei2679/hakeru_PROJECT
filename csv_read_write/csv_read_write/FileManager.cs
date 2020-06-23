namespace csv_read_write
{
    class FileManager
    {
        private readonly string filePath;
        private readonly CsvFileReadWrite csvReadWrite;

        public FileManager(string path)
        {
            filePath = path;
            csvReadWrite = new CsvFileReadWrite(path);
        }

        public string FilePath { get { return filePath; } private set { } }
        public CsvFileReadWrite ReadWrite { get { return csvReadWrite; } private set { } }

    }
}
