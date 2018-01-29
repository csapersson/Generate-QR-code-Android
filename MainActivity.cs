using Android.App;
using Android.Widget;
using Android.OS;

namespace QRAndroid {
    [Activity(Label = "QR-Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity {
    ImageView imageBarcode;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set view.
            SetContentView(Resource.Layout.Main);

            // Resources.
            imageBarcode = FindViewById<ImageView>(Resource.Id.qrImageView);

            // Create a QR code.
            var barcodeWriter = new ZXing.Mobile.BarcodeWriter {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions {
                    Width = 300,
                    Height = 300
                }
            };

            // String to become QR code.
            var qrString = barcodeWriter.Write("Hello world!");

            // Assign QR code to ImageView.
            imageBarcode.SetImageBitmap(qrString);
        }
    }
}