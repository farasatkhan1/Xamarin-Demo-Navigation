using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoShellNavigation.Controls;
using DemoShellNavigation.Droid.CustomRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace DemoShellNavigation.Droid.CustomRenderer
{
    class CustomButtonRenderer: Xamarin.Forms.Platform.Android.ButtonRenderer
    {
        public CustomButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var button = Control;

                button.SetTextColor(Android.Graphics.Color.White);
                button.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);
                button.SetPadding(0, 20, 0, 0);

                GradientDrawable drawable = new GradientDrawable();
                drawable.SetCornerRadius(75);
                drawable.SetColor(Android.Graphics.Color.ParseColor("#007AFF"));
                button.SetBackground(drawable);
            }
        }
    }
}