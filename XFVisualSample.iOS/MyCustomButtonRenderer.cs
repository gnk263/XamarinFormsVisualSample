using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFVisualSample;
using XFVisualSample.iOS;


[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(MyCustomButtonRenderer), new[] { typeof(MyCustomVisual) })]
namespace XFVisualSample.iOS
{
    public class MyCustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.BackgroundColor = Color.LightCoral.ToUIColor();
            }
        }
    }
}
