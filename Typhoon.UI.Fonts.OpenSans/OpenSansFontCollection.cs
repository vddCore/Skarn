using System;
using Avalonia.Media.Fonts;

namespace Typhoon.UI.Fonts.OpenSans
{
    public class OpenSansFontCollection : EmbeddedFontCollection
    {
        public OpenSansFontCollection() : base(
            new Uri("fonts:OpenSans", UriKind.Absolute),
            new Uri("avares://Typhoon.UI.Fonts.OpenSans/Assets", UriKind.Absolute))
        {
        }
    }
}