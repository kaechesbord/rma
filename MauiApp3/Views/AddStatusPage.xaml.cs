using Microsoft.Maui.Platform;

namespace MauiApp3.Views;

public partial class AddStatusPage : ContentPage
{
	public AddStatusPage()
	{
		InitializeComponent();
        // Dodajemo "ispravku" samo za ovaj konkretan Editor
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("SkloniBorder", (handler, view) =>
        {
            if (view == StatusEditor) 
            {
#if ANDROID
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#endif
#if ANDROID
                // Na novijim Android verzijama (API 29+) koristi se TextCursorDrawable
                if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Q)
                {
                    handler.PlatformView.TextCursorDrawable?.SetTint(Microsoft.Maui.Graphics.Colors.White.ToPlatform());
                }
#elif IOS
        // Na iOS-u se boja kursora zove TintColor
        handler.PlatformView.TintColor = UIKit.UIColor.SystemPink;
#elif WINDOWS
        // Na Windows-u je to SelectionHighlightColor
        handler.PlatformView.SelectionHighlightColor = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.DeepPink);
#endif
            }
        });

    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        // "Pop" skida trenutnu stranicu sa vrha steka i vraća te nazad
        await Navigation.PopAsync();
    }
}