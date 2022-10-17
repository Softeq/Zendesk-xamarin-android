using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Com.Zendesk.Logger;
using Com.Zendesk.Service;
using GoogleGson.Stream;
using Zendesk.Core;
using Zendesk.Support;
using Zendesk.Support.Guide;
using Zendesk.Support.Request;
using Zendesk.Support.Requestlist;
using Zendesk.Chat;
using Zendesk.Messaging;

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

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            var fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;


            InitZendesk();
        }

        private void InitZendesk()
        {
            // Enable Zendesk SDK logs
            Logger.Loggable = true;

            // TODO: Add valid credentials:
            // Init SDK
            Zendesk.Core.Zendesk.Instance.Init(this,
                zendeskUrl: "",
                applicationId: "",
                oauthClientId: "");

            // Init user
            var identity = new AnonymousIdentity.Builder()
                .WithNameIdentifier(name: "TestUserName")
                .WithEmailIdentifier(email: "test@test.com")
                .Build();
            Zendesk.Core.Zendesk.Instance.Identity = identity;

            // Init Support
            // https://developer.zendesk.com/documentation/classic-web-widget-sdks/support-sdk/android/nutshell/
            Support.Instance.Init(Zendesk.Core.Zendesk.Instance);

            // Init Chat
            // https://developer.zendesk.com/documentation/classic-web-widget-sdks/chat-sdk-v2/android/getting-started/
            // https://developer.zendesk.com/documentation/classic-web-widget-sdks/chat-sdk-v2/android/quick-start-chat-sdk-android/
            Chat.Instance.Init(
                    this,
                    "Your accountKey",
                    "Your appId");
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            // Simple configuration for chat
            ChatConfiguration chatConfiguration = ChatConfiguration.InvokeBuilder()
                .WithAgentAvailabilityEnabled(false)
                .Build();

            // Show Zendesk Chat
            MessagingActivity.Builder()
                .WithEngines(ChatEngine.Engine())
                .Show(this, chatConfiguration);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.action_help:
                    HelpCenterActivity.Builder().Show(this);
                    return true;

                case Resource.Id.action_tickets:
                    RequestListActivity.Builder().Show(this);
                    return true;

                case Resource.Id.action_request:
                    RequestActivity.Builder().Show(this);
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
