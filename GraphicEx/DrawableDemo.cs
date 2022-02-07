using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class DrawableDemo : Activity
    {
       // TextView myTextV;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DrawDemo);

           // myTextV = FindViewById<TextView>(Resource.Id.textView1);
          //  myTextV.SetBackgroundResource(Resource.Drawable.shape_round_blue_rectangle);
        }
    }
}