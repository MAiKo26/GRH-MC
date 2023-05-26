package com.example.mcgrhpfe_2021;

import androidx.appcompat.app.AppCompatActivity;
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

public class EmployeActivity extends AppCompatActivity {

    RecyclerView recyclerView ;
    EmployeAdapter adapter ;
    List<Employe> EmployeList ;

    private static final String TAG = "EmployeActivity";

    DrawerLayout drawerLayout ;

    DatabaseReference databaseemploye ;



    ValueEventListener valueEventListener = new ValueEventListener() {
        @Override
        public void onDataChange(DataSnapshot dataSnapshot) {
            EmployeList.clear() ;
            if (dataSnapshot.exists()) {
                for (DataSnapshot snapshot : dataSnapshot.getChildren()){
                    Employe Employe = snapshot.getValue(Employe.class) ;
                    EmployeList.add(Employe) ;

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
        setContentView(R.layout.activity_employe);
        getSupportActionBar().hide() ;

        drawerLayout = findViewById(R.id.drawer_layout) ;


        Log.d(TAG, "onCreate: 1");

        recyclerView = (RecyclerView) findViewById(R.id.recyclerViewE) ;
        Log.d(TAG, "onCreate: 2");
        recyclerView.setHasFixedSize(true);
        Log.d(TAG, "onCreate: 3");

        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        Log.d(TAG, "onCreate: 4");

        EmployeList = new ArrayList<>() ;

        adapter = new EmployeAdapter(this , EmployeList) ;

        recyclerView.setAdapter(adapter);
        Log.d(TAG, "onCreate: 5");
        databaseemploye = FirebaseDatabase.getInstance().getReference().child("Liste_Employes") ;
        Log.d(TAG, "onCreate: 6");
        databaseemploye.addListenerForSingleValueEvent(valueEventListener);
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
        MissionAffecteActivity.redirectActivity(this,PartenaireActivity.class);


    }

    public void ClickEmploye(View view){

        recreate();

    }

    public void ClickMission(View view){

        MissionAffecteActivity.redirectActivity(this,MissionActivity.class);


    }

    public void ClickApropos(View view){
        MissionAffecteActivity.redirectActivity(this,AproposActivity.class);
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