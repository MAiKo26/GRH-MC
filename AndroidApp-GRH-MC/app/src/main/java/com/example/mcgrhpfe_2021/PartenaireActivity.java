package com.example.mcgrhpfe_2021;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.util.Log;
import android.view.View;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;
import java.util.List;

import static java.lang.Boolean.TRUE;

public class PartenaireActivity extends AppCompatActivity {


    RecyclerView recyclerView ;
    PartenaireAdapter adapter ;
    List<Partenaire> PartenaireList ;

    private static final String TAG = "PartenaireActivity";

    DrawerLayout drawerLayout ;

    DatabaseReference databasepartenaire ;



    ValueEventListener valueEventListener = new ValueEventListener() {
        @Override
        public void onDataChange(DataSnapshot dataSnapshot) {
            PartenaireList.clear() ;
            if (dataSnapshot.exists()) {
                for (DataSnapshot snapshot : dataSnapshot.getChildren()){
                    Partenaire partenaire = snapshot.getValue(Partenaire.class) ;
                    PartenaireList.add(partenaire) ;

                }
                adapter.notifyDataSetChanged();
            }

        }

        @Override
        public void onCancelled(DatabaseError error) {

        }

    } ;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_partenaire);
        drawerLayout = findViewById(R.id.drawer_layoutP) ;
        getSupportActionBar().hide() ;

        Log.d(TAG, "onCreate: 1");

        recyclerView = (RecyclerView) findViewById(R.id.recyclerViewP) ;
        Log.d(TAG, "onCreate: 2");
        recyclerView.setHasFixedSize(true);
        Log.d(TAG, "onCreate: 3");

        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        Log.d(TAG, "onCreate: 4");

        PartenaireList = new ArrayList<>() ;

        adapter = new PartenaireAdapter(this , PartenaireList) ;

        recyclerView.setAdapter(adapter);
        Log.d(TAG, "onCreate: 5");
        databasepartenaire = FirebaseDatabase.getInstance().getReference().child("Liste_Partenaires") ;
        Log.d(TAG, "onCreate: 6");
        databasepartenaire.addListenerForSingleValueEvent(valueEventListener);
        Log.d(TAG, "onCreate: 7");
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
        recreate();


    }

    public void ClickEmploye(View view){

        MissionAffecteActivity.redirectActivity(this,EmployeActivity.class);


    }

    public void ClickMission(View view){

        MissionAffecteActivity.redirectActivity(this,MissionActivity.class);


    }

    public void ClickLogout(View view){

        MissionAffecteActivity.logout(this) ;

    }

    public void ClickApropos(View view){
        MissionAffecteActivity.redirectActivity(this,AproposActivity.class);
    }

    @Override
    protected void onPause() {
        super.onPause();

        MissionAffecteActivity.closeDrawer(drawerLayout);
    }


}