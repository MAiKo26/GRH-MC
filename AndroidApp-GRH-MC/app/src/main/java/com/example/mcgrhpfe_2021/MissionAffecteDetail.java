package com.example.mcgrhpfe_2021;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;


public class MissionAffecteDetail extends AppCompatActivity {
    private Context mCtx ;


    private static final String TAG = "LayoutDetail";

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mission_affecte_detail);

        getSupportActionBar().hide();

        Log.d(TAG,"OnCreate MissioNAffecteDetail : Started") ;


        setIncomingIntent();



    }


    private void setIncomingIntent(){

        Log.d(TAG, "getIncomingIntent: checking for incoming intents");

        if(getIntent().hasExtra("DateM")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String DateM = getIntent().getStringExtra("DateM") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView) ;
            TextView.setText(DateM) ;
        }

        if(getIntent().hasExtra("CodeM")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String CodeM = getIntent().getStringExtra("CodeM") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView2) ;
            TextView.setText(CodeM) ;
        }

        if(getIntent().hasExtra("CodeE")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String CodeE = getIntent().getStringExtra("CodeE") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView3) ;
            TextView.setText(CodeE) ;

        }

        if(getIntent().hasExtra("CodeP")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String CodeP = getIntent().getStringExtra("CodeP") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView4) ;
            TextView.setText(CodeP) ;

        }

        if(getIntent().hasExtra("HA")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String HA = getIntent().getStringExtra("HA") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView5) ;
            TextView.setText(HA) ;

        }

        if(getIntent().hasExtra("HD")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String HD = getIntent().getStringExtra("HD") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView6) ;
            TextView.setText(HD) ;
        }

        if(getIntent().hasExtra("Adresse")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Adresse = getIntent().getStringExtra("Adresse") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView7) ;
            TextView.setText(Adresse) ;
        }

        if(getIntent().hasExtra("Objet")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Objet = getIntent().getStringExtra("Objet") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView8) ;
            TextView.setText(Objet) ;
        }

        if(getIntent().hasExtra("Unite")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Unite = getIntent().getStringExtra("Unite") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView9) ;
            TextView.setText(Unite) ;
        }

        if(getIntent().hasExtra("PrixU")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String PrixU = getIntent().getStringExtra("PrixU") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView10) ;
            TextView.setText(PrixU) ;
        }


        if(getIntent().hasExtra("Info1")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Info1 = getIntent().getStringExtra("Info1") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView11) ;
            TextView.setText(Info1) ;
        }

        if(getIntent().hasExtra("Info2")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Info2 = getIntent().getStringExtra("Info2") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView12) ;
            TextView.setText(Info2) ;
        }

        if(getIntent().hasExtra("Info3")){
            Log.d(TAG, "getIncomingIntent: found extent");
            String Info3 = getIntent().getStringExtra("Info3") ;

            Log.d(TAG, "setIncomingIntent: started");
            TextView TextView = findViewById(R.id.textView13) ;
            TextView.setText(Info3) ;
        }



    }


}