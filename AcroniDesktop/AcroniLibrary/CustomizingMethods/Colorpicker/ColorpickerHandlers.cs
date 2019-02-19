using System.Drawing;

namespace AcroniBLL.CustomizingMethods.Colorpicker
{
    class ColorpickerHandlers
    {
        internal static int NoOfColorsVisibleOnDisplay { get; set; }
        internal static bool IsChosen { get; set; } = true;
        internal static Color ChosenColor { get; set; }
    }
}
