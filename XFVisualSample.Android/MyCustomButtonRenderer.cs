
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFVisualSample;
using XFVisualSample.Droid;
using ButtonRenderer = Xamarin.Forms.Platform.Android.AppCompat.ButtonRenderer;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(MyCustomButtonRenderer), new[] { typeof(MyCustomVisual) })]
namespace XFVisualSample.Droid
{
    public class MyCustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.SetBackgroundColor(Color.LightCoral.ToAndroid());
            }
        }
    }
}