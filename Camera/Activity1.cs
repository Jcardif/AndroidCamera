using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Graphics;
using Android.Widget;

namespace Camera
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        ImageView imgview2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout1);
            imgview2 = FindViewById < ImageView>(Resource.Id.imageView2);
            

        }
    }
}