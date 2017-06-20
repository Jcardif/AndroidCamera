using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Widget;

namespace Camera
{
    [Activity(Label = "Camera", MainLauncher = true, Icon = "@drawable/icon")]
    public  class MainActivity : Activity
    {
        ImageView imgview1;
        Button camerabtn;
        Button done;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            imgview1 = FindViewById<ImageView>(Resource.Id.imageView1);
            camerabtn = FindViewById<Button>(Resource.Id.button1);
            done = FindViewById<Button>(Resource.Id.button2);

            camerabtn.Click += Camerabtn_Click;
            done.Click += delegate { StartActivity(typeof(Activity1)); };
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            Bitmap bitmap = (Bitmap)data.Extras.Get("data");
            imgview1.SetImageBitmap(bitmap);

        }
        private void Camerabtn_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            StartActivityForResult(intent, 0);
        }
    }
}

