using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Zendesk.Core;
using Zendesk.Support;
using Zendesk.Support.Guide;
using Zendesk.Support.Request;


namespace SampleApp
{
    [Activity(
        Label = "@string/app_name",
        Theme = "@style/AppTheme.NoActionBar",
        MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            InitZendesk();

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
        }

        private void InitZendesk()
        {
            // TODO: Add valid credentials:
            Zendesk.Core.Zendesk.Instance.Init(this,
                zendeskUrl: "",
                applicationId: "",
                oauthClientId: "");

            var identity = new AnonymousIdentity.Builder()
                .WithNameIdentifier(name: "")
                .WithEmailIdentifier(email: "")
                .Build();

            Zendesk.Core.Zendesk.Instance.Identity = identity;

            Support.Instance.Init(Zendesk.Core.Zendesk.Instance);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            RequestActivity.Builder().Show(this);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                HelpCenterActivity.Builder().Show(this);
                
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
