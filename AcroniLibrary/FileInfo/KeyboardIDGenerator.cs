using System;

namespace AcroniLibrary.FileInfo
{
    class IDGenerator
    {
        static string GenerateID()
        {
            return $"{DateTime.UtcNow}";
        }
    }
}
