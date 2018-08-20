namespace AcroniLibrary.FileInfo
{
    class IDGenerator<T>
    {
        static string GenerateID(T keyboardType)
        {
            return $"{typeof(T)}{GetTime.GetNistTime()}";
        }
    }
}
