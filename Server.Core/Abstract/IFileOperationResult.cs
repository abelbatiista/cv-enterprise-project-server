namespace Server.Core.Abstract
{
    public interface IFileInfoModel
    {
        string FileName { get; }
        string ContentType { get; }
    }
    public class FileInfoModel : IFileInfoModel
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
    }
    public interface IFileOperationResult<T>
    {
        bool IsSuccess { get; }
        T Entity { get; }
        string Message { get; }
        string FileName { get; }
    }
    public class FileOperationResult<T> : IFileOperationResult<T>
    {
        public bool IsSuccess { get; set; }
        public T Entity { get; set; }
        public string Message { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
    }
}
