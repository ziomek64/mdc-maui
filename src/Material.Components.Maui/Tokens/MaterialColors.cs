﻿using Material.Components.Maui.Extensions;
using MaterialColorUtilities.Palettes;
using MaterialColorUtilities.Schemes;

namespace Material.Components.Maui.Tokens;

public static class SchemeExtensions
{
    public static Scheme<Color> GetDefaultScheme(AppTheme theme = AppTheme.Light)
    {
        var result = new Scheme<Color>();
        if (theme is AppTheme.Light)
        {
            result.Primary = Color.Parse("#6750A4");
            result.PrimaryContainer = Color.Parse("#EADDFF");
            result.OnPrimary = Color.Parse("#FFFFFF");
            result.OnPrimaryContainer = Color.Parse("#21005E");
            result.InversePrimary = Color.Parse("#D0BCFF");

            result.Secondary = Color.Parse("#625B71");
            result.SecondaryContainer = Color.Parse("#E8DEF8");
            result.OnSecondary = Color.Parse("#FFFFFF");
            result.OnSecondaryContainer = Color.Parse("#1E192B");

            result.Tertiary = Color.Parse("#7D5260");
            result.TertiaryContainer = Color.Parse("#FFD8E4");
            result.OnTertiary = Color.Parse("#FFFFFF");
            result.OnTertiaryContainer = Color.Parse("#370B1E");

            result.Surface = Color.Parse("#FFFBFE");
            result.SurfaceDim = Color.Parse("#DED8E1");
            result.SurfaceBright = Color.Parse("#FEF7FF");
            result.SurfaceContainerLowest = Color.Parse("#FFFFFF");
            result.SurfaceContainerLow = Color.Parse("#F7F2FA");
            result.SurfaceContainerLow = Color.Parse("#F7F2FA");
            result.SurfaceContainer = Color.Parse("#F3EDF7");
            result.SurfaceContainerHigh = Color.Parse("#ECE6F0");
            result.SurfaceContainerHighest = Color.Parse("#E6E0E9");
            result.SurfaceVariant = Color.Parse("#E6E0E9");
            result.OnSurface = Color.Parse("#1C1B1F");
            result.OnSurfaceVariant = Color.Parse("#49454E");
            result.InverseSurface = Color.Parse("#313033");
            result.InverseOnSurface = Color.Parse("#F4EFF4");

            result.Background = Color.Parse("#FFFBFE");
            result.OnBackground = Color.Parse("#1C1B1F");

            result.Error = Color.Parse("#B3261E");
            result.ErrorContainer = Color.Parse("#F9DEDC");
            result.OnError = Color.Parse("#FFFFFF");
            result.OnErrorContainer = Color.Parse("#370B1E");

            result.Outline = Color.Parse("#79747E");
            result.OutlineVariant = Color.Parse("#C4C7C5");

            result.Shadow = Color.Parse("#000000");
            //result.SurfaceTint = Color.Parse("#6750A4");
        }
        else
        {
            result.Primary = Color.Parse("#D0BCFF");
            result.PrimaryContainer = Color.Parse("#4F378B");
            result.Secondary = Color.Parse("#CCC2DC");
            result.SecondaryContainer = Color.Parse("#4A4458");
            result.Tertiary = Color.Parse("#EFB8C8");
            result.TertiaryContainer = Color.Parse("#633B48");
            result.Surface = Color.Parse("#1C1B1F");
            result.SurfaceVariant = Color.Parse("#49454F");
            result.Background = Color.Parse("#1C1B1F");
            result.Error = Color.Parse("#F2B8B5");
            result.ErrorContainer = Color.Parse("#8C1D18");
            result.OnPrimary = Color.Parse("#371E73");
            result.OnPrimaryContainer = Color.Parse("#EADDFF");
            result.OnSecondary = Color.Parse("#332D41");
            result.OnSecondaryContainer = Color.Parse("#E8DEF8");
            result.OnTertiary = Color.Parse("#492532");
            result.OnTertiaryContainer = Color.Parse("#FFD8E4");
            result.OnSurface = Color.Parse("#E6E1E5");
            result.OnSurfaceVariant = Color.Parse("#CAC4D0");
            result.OnError = Color.Parse("#601410");
            result.OnErrorContainer = Color.Parse("#F9DEDC");
            result.OnBackground = Color.Parse("#E6E1E5");
            result.Outline = Color.Parse("#938F99");
            result.Shadow = Color.Parse("#000000");
            result.InverseSurface = Color.Parse("#E6E1E5");
            result.InverseOnSurface = Color.Parse("#313033");
            result.InversePrimary = Color.Parse("#6750A4");
        }
        return result;
    }

    public static Scheme<Color> GetScheme(this Color seedColor, AppTheme theme = AppTheme.Light)
    {
        var corePalette = CorePalette.Of(seedColor.ToUint());
        dynamic schemeMapper =
            theme is AppTheme.Dark ? new DarkSchemeMapper() : new LightSchemeMapper();
        Scheme<uint> scheme = schemeMapper.Map(corePalette);
        var result = scheme.Convert(Color.FromUint);
        return result;
    }
}

public static class MaterialColors
{
    public static ResourceDictionary Colors => ResourceExtension.ColorRes;

    public static Color Primary => (Color)Colors["PrimaryColor"];
    public static Color PrimaryContainer => (Color)Colors["PrimaryContainerColor"];
    public static Color OnPrimary => (Color)Colors["OnPrimaryColor"];
    public static Color OnPrimaryContainer => (Color)Colors["OnPrimaryContainerColor"];
    public static Color InversePrimary => (Color)Colors["InversePrimaryColor"];

    public static Color Secondary => (Color)Colors["SecondaryColor"];
    public static Color SecondaryContainer => (Color)Colors["SecondaryContainerColor"];
    public static Color OnSecondary => (Color)Colors["OnSecondaryColor"];
    public static Color OnSecondaryContainer => (Color)Colors["OnSecondaryContainerColor"];

    public static Color Tertiary => (Color)Colors["TertiaryColor"];
    public static Color TertiaryContainer => (Color)Colors["TertiaryContainerColor"];
    public static Color OnTertiary => (Color)Colors["OnTertiaryColor"];
    public static Color OnTertiaryContainer => (Color)Colors["OnTertiaryContainerColor"];

    public static Color Surface => (Color)Colors["SurfaceColor"];
    public static Color SurfaceDim => (Color)Colors["SurfaceDimColor"];
    public static Color SurfaceBright => (Color)Colors["SurfaceBrightColor"];
    public static Color SurfaceContainerLowest => (Color)Colors["SurfaceContainerLowestColor"];
    public static Color SurfaceContainerLow => (Color)Colors["SurfaceContainerLowColor"];
    public static Color SurfaceContainer => (Color)Colors["SurfaceContainerColor"];
    public static Color SurfaceContainerHigh => (Color)Colors["SurfaceContainerHighColor"];
    public static Color SurfaceContainerHighest => (Color)Colors["SurfaceContainerHighestColor"];
    public static Color SurfaceVariant => (Color)Colors["SurfaceVariantColor"];
    public static Color OnSurface => (Color)Colors["OnSurfaceColor"];
    public static Color OnSurfaceVariant => (Color)Colors["OnSurfaceVariantColor"];
    public static Color InverseSurface => (Color)Colors["InverseSurfaceColor"];
    public static Color InverseOnSurface => (Color)Colors["InverseOnSurfaceColor"];

    public static Color Background => (Color)Colors["BackgroundColor"];
    public static Color OnBackground => (Color)Colors["OnBackgroundColor"];

    public static Color Error => (Color)Colors["ErrorColor"];
    public static Color ErrorContainer => (Color)Colors["ErrorContainerColor"];
    public static Color OnError => (Color)Colors["OnErrorColor"];
    public static Color OnErrorContainer => (Color)Colors["OnErrorContainerColor"];

    public static Color Outline => (Color)Colors["OutlineColor"];
    public static Color OutlineVariant => (Color)Colors["OutlineVariantColor"];

    public static Color Shadow => (Color)Colors["ShadowColor"];
    public static Color SurfaceTint => (Color)Colors["SurfaceTintColor"];
}
