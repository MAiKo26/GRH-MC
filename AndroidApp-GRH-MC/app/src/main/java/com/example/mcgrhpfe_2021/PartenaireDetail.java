package com.example.mcgrhpfe_2021;

import android.content.Context;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class PartenaireDetail extends AppCompatActivity {
    private Context mCtx ;


    private static final String TAG = "LayoutDetail";

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_partenaire_detail);

        getSupportActionBar().hide();

        Log.d(TAG, "OnCreate PartenaireDetail : Started");


        setIncomingIntent();


    }

    private void setIncomingIntent() {

        Log.d(TAG, "getIncomingIntent: checking for incoming intents");

        if(getIntent().hasExtra("CodeP")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String CodeP = getIntent().getStringExtra("CodeP") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView) ;
            TextView.setText(CodeP) ;
        }

        if(getIntent().hasExtra("Type")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Type = getIntent().getStringExtra("Type") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView2) ;
            TextView.setText(Type) ;
        }

        if(getIntent().hasExtra("Adresse")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Adresse = getIntent().getStringExtra("Adresse") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView3) ;
            TextView.setText(Adresse) ;

        }

        if(getIntent().hasExtra("Nom")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Nom = getIntent().getStringExtra("Nom") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView4) ;
            TextView.setText(Nom) ;

        }

        if(getIntent().hasExtra("Mobile")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Mobile = getIntent().getStringExtra("Mobile") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView5) ;
            TextView.setText(Mobile) ;

        }

        if(getIntent().hasExtra("Telephone")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Telephone = getIntent().getStringExtra("Telephone") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView6) ;
            TextView.setText(Telephone) ;
        }

        if(getIntent().hasExtra("Ville")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Ville = getIntent().getStringExtra("Ville") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView7) ;
            TextView.setText(Ville) ;
        }

        if(getIntent().hasExtra("Pays")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Pays = getIntent().getStringExtra("Pays") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView8) ;
            TextView.setText(Pays) ;
        }

        if(getIntent().hasExtra("Info1")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Info1 = getIntent().getStringExtra("Info1") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView9) ;
            TextView.setText(Info1) ;
        }

        if(getIntent().hasExtra("Info2")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Info2 = getIntent().getStringExtra("Info2") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView10) ;
            TextView.setText(Info2) ;
        }


        if(getIntent().hasExtra("Info3")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Info3 = getIntent().getStringExtra("Info3") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView11) ;
            TextView.setText(Info3) ;
        }









    }
}