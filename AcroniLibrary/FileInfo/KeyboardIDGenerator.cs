using System;
using System.Windows.Forms;
using AcroniUI.CustomizingForms;

namespace AcroniLibrary.FileInfo
{
    class KeyboardIDGenerator
    {
        static string GenerateID(Form formBeingUsedOnCustomizing)
        {
            if (formBeingUsedOnCustomizing is Compacto)
                return $"C{DateTime.UtcNow}";
            else if (formBeingUsedOnCustomizing is Fullsize)
                return $"F{DateTime.UtcNow}";
            else
                return $"T{DateTime.UtcNow}";
        }
    }
}
