package com.example.mcgrhpfe_2021;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;

@SuppressWarnings("deprecation")
public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getSupportActionBar().hide() ;

        new Handler().postDelayed(new Runnable(){

            public void run(){

                Intent intent = new Intent(MainActivity.this , MissionAffecteActivity.class) ;
                startActivity(intent) ;
                finish();

            }

        },3000) ;


    }
}