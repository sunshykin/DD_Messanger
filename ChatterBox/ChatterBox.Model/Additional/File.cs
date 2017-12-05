
namespace ChatterBox.Model.Additional
{
    public class File
    {
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Файл
        /// </summary>
        public byte[] FileData { get; set; }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя файла</param>
        /// <param name="data">Файл</param>
        public File(string name, byte[] data)
        {
            FileName = name;
            FileData = data;
        }
    }
}
