using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace LocalContact
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ContactModel[] contacts = new ContactModel[]
        {
            new ContactModel("Nextflow", "083-071-3373"),
            new ContactModel("Steve", "083-071-3373"),
            new ContactModel("Tony", "083-071-3373"),
            new ContactModel("Peter", "083-071-3373")
        };


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            var listView = FindViewById<ListView>(Resource.Id.listViewContact);

            listView.Adapter = new ContactModelListAdapter(this, this.contacts);


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}