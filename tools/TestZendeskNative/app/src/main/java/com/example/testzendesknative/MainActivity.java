package com.example.testzendesknative;

import static zendesk.support.HelpCenterTracker.*;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.zendesk.logger.Logger;

import zendesk.chat.Chat;
import zendesk.chat.ChatConfiguration;
import zendesk.chat.ChatEngine;
import zendesk.core.AnonymousIdentity;
import zendesk.core.Identity;
import zendesk.core.Zendesk;
import zendesk.messaging.MessagingActivity;
import zendesk.support.Support;
import zendesk.support.request.RequestActivity;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(view -> {
            //Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
            //        .setAction("Action", null).show();

            // Simple configuration for chat
            ChatConfiguration chatConfiguration = ChatConfiguration.builder()
                    .withAgentAvailabilityEnabled(false)
                    .build();

            // Show Zendesk Chat
            MessagingActivity.builder()
                    .withEngines(ChatEngine.engine())
                    .show(view.getContext(), chatConfiguration);
        });

        // Enable Zendesk SDK logs
        Logger.setLoggable(true);

        // Init SDK
        Zendesk.INSTANCE.init(
                this,
                "Your zendeskUrl",
                "Your appId",
                "Your clientId");

        // Init user
        Identity identity = new AnonymousIdentity();
        Zendesk.INSTANCE.setIdentity(identity);

        // Init Support
        // https://developer.zendesk.com/documentation/classic-web-widget-sdks/support-sdk/android/nutshell/
        Support.INSTANCE.init(Zendesk.INSTANCE);

        // Init Chat
        // https://developer.zendesk.com/documentation/classic-web-widget-sdks/chat-sdk-v2/android/getting-started/
        // https://developer.zendesk.com/documentation/classic-web-widget-sdks/chat-sdk-v2/android/quick-start-chat-sdk-android/
        Chat.INSTANCE.init(
                this,
                "Your accountKey",
                "Your appId");
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_request) {

            // Simple configuration for show new Zendesk Support request
            RequestActivity.builder()
                    .withRequestSubject("Testing Support SDK")
                    .withTags("sdk", "android")
                    .show(this);

            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}