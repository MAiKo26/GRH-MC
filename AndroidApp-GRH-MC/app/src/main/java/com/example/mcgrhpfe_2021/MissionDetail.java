package com.example.mcgrhpfe_2021;

import android.content.Context;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class MissionDetail extends AppCompatActivity {
    private Context mCtx ;


    private static final String TAG = "LayoutDetail";

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mission_detail);

        getSupportActionBar().hide();

        Log.d(TAG, "OnCreate MissionDetail : Started");


        setIncomingIntent();


    }

    private void setIncomingIntent() {

        Log.d(TAG, "getIncomingIntent: checking for incoming intents");

        if(getIntent().hasExtra("CodeM")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String CodeM = getIntent().getStringExtra("CodeM") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView) ;
            TextView.setText(CodeM) ;
        }

        if(getIntent().hasExtra("Libelle")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Libelle = getIntent().getStringExtra("Libelle") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView2) ;
            TextView.setText(Libelle) ;
        }

        if(getIntent().hasExtra("Type")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Type = getIntent().getStringExtra("Type") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView3) ;
            TextView.setText(Type) ;

        }

        if(getIntent().hasExtra("Info1")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Info1 = getIntent().getStringExtra("Info1") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView4) ;
            TextView.setText(Info1) ;

        }

        if(getIntent().hasExtra("Info2")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Info2 = getIntent().getStringExtra("Info2") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView5) ;
            TextView.setText(Info2) ;

        }

        if(getIntent().hasExtra("Info3")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Info3 = getIntent().getStringExtra("Info3") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView6) ;
            TextView.setText(Info3) ;
        }

    }
}
