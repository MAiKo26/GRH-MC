package com.example.mcgrhpfe_2021;

import android.os.Bundle;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;
import androidx.drawerlayout.widget.DrawerLayout;

public class AproposActivity extends AppCompatActivity {

    DrawerLayout drawerLayout ;

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_apropos);
        drawerLayout = findViewById(R.id.drawer_layoutAP) ;

        getSupportActionBar().hide();


    }





    public void ClickMenu(View view){
        MissionAffecteActivity.openDrawer(drawerLayout) ;

    }

    public void ClickLogo(View view){

        MissionAffecteActivity.closeDrawer(drawerLayout);
    }

    public void ClickMissionAffecte(View view){
        MissionAffecteActivity.redirectActivity(this,MissionAffecteActivity.class);

    }

    public void ClickPartenaire (View view){

        MissionAffecteActivity.redirectActivity(this,PartenaireActivity.class);


    }

    public void ClickEmploye(View view){

        MissionAffecteActivity.redirectActivity(this,EmployeActivity.class);


    }

    public void ClickMission(View view){

        MissionAffecteActivity.redirectActivity(this,MissionActivity.class);


    }

    public void ClickApropos(View view){
        recreate();
    }

    public void ClickLogout(View view){

        MissionAffecteActivity.logout(this) ;

    }



    @Override
    protected void onPause() {
        super.onPause();

        MissionAffecteActivity.closeDrawer(drawerLayout);
    }

}
