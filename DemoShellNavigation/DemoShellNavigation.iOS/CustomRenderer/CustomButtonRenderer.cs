using CoreGraphics;
using DemoShellNavigation.Controls;
using DemoShellNavigation.iOS.CustomRenderer;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace DemoShellNavigation.iOS.CustomRenderer
{
    class CustomButtonRenderer: Xamarin.Forms.Platform.iOS.ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var button = Control;
                button.SetTitleColor(UIColor.White, UIControlState.Normal);
                button.Font = UIFont.BoldSystemFontOfSize(button.Font.PointSize);
                button.ContentEdgeInsets = new UIEdgeInsets(20, 0, 0, 0);

                button.Layer.CornerRadius = 75;
                button.Layer.BackgroundColor = UIColor.FromRGB(0, 122, 255).CGColor;
                button.ClipsToBounds = true;
            }
        }
    }
}