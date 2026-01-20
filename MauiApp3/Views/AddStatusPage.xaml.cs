using Microsoft.Maui.Platform;

namespace MauiApp3.Views;

public partial class AddStatusPage : ContentPage
{
	public AddStatusPage()
	{
		InitializeComponent();
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("SkloniBorder", (handler, view) =>
        {
            if (view == StatusEditor) 
            {
#if ANDROID
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#endif
#if ANDROID
                if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Q)
                {
                    handler.PlatformView.TextCursorDrawable?.SetTint(Microsoft.Maui.Graphics.Colors.White.ToPlatform());
                }
#elif IOS
        handler.PlatformView.TintColor = UIKit.UIColor.SystemPink;
#elif WINDOWS
        handler.PlatformView.SelectionHighlightColor = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.DeepPink);
#endif
            }
        });

    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}