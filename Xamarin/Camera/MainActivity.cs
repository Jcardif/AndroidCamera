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
        ImageView _imgview1;
        Button _camerabtn;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            _imgview1 = FindViewById<ImageView>(Resource.Id.capturedImageView);
            _camerabtn = FindViewById<Button>(Resource.Id.cameraBtn);

            _camerabtn.Click += CameraBtn_Click;
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (data.Extras == null) 
                return;

            var bitmap = (Bitmap)data.Extras.Get("data");
            _imgview1.SetImageBitmap(bitmap);
        }
        private void CameraBtn_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            StartActivityForResult(intent, 0);
        }
    }
}

