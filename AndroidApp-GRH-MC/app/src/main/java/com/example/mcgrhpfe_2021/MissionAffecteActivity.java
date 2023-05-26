 package com.example.mcgrhpfe_2021;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;

import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;


// import com.firebase.ui.database.FirebaseRecyclerOptions;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;
import com.google.firebase.database.core.Path;

import java.util.ArrayList;
import java.util.List;

public class MissionAffecteActivity extends AppCompatActivity {

    RecyclerView recyclerView ;
    MissionEmployeAdapter adapter ;
    List<MissionEmploye> MissionEmpList ;

    private static final String TAG = "HomeActivity";

    DrawerLayout drawerLayout ;


    DatabaseReference databaseMissionEmp ;


    ValueEventListener valueEventListener = new ValueEventListener() {
        @Override
        public void onDataChange(DataSnapshot dataSnapshot) {
            MissionEmpList.clear() ;
            if (dataSnapshot.exists()) {
                for (DataSnapshot snapshot : dataSnapshot.getChildren()){
                    MissionEmploye missionEmp = snapshot.getValue(MissionEmploye.class) ;
                    MissionEmpList.add(missionEmp) ;

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
        setContentView(R.layout.activity_mission_affecte);
        drawerLayout = findViewById(R.id.drawer_layout) ;
        getSupportActionBar().hide() ;





        recyclerView = (RecyclerView) findViewById(R.id.recyclerView) ;

        recyclerView.setHasFixedSize(true);

        recyclerView.setLayoutManager(new LinearLayoutManager(this));


        MissionEmpList = new ArrayList<>() ;

        adapter = new MissionEmployeAdapter(this,MissionEmpList) ;

        recyclerView.setAdapter(adapter);


        databaseMissionEmp = FirebaseDatabase.getInstance().getReference().child("Liste_AffecteMissions") ;


        databaseMissionEmp.addListenerForSingleValueEvent(valueEventListener);

    }

    public void ClickMenu (View view){
        openDrawer(drawerLayout) ;

    }

    public static void openDrawer(DrawerLayout drawerLayout) {

        drawerLayout.openDrawer(GravityCompat.START);

    }

    public void ClickLogo (View view){

        closeDrawer(drawerLayout) ;

    }

    public static void closeDrawer(DrawerLayout drawerLayout) {

        if(drawerLayout.isDrawerOpen(GravityCompat.START)){
            drawerLayout.closeDrawer(GravityCompat.START);}

    }

    public void ClickMissionAffecte(View view){
        recreate();

    }

    public void ClickPartenaire (View view){
        redirectActivity(this,PartenaireActivity.class);


    }

    public void ClickEmploye(View view){

        redirectActivity(this,EmployeActivity.class);


    }

    public void ClickMission(View view){

        redirectActivity(this,MissionActivity.class);


    }

    public void ClickApropos(View view){
        MissionAffecteActivity.redirectActivity(this,AproposActivity.class);
    }

    public void ClickLogout(View view){

        logout(this) ;

    }

    public static void logout(Activity activity) {

        AlertDialog.Builder builder = new AlertDialog.Builder(activity) ;
        builder.setTitle("Logout") ;
        builder.setMessage("Are you sure you want to logout ?") ;
        builder.setPositiveButton("YES", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

                activity.finishAffinity();
                System.exit(0) ;
            }
        });
        builder.setNegativeButton("NO", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.dismiss();
            }
        });

        builder.show();

    }

    public static void redirectActivity(Activity activity, Class aClass) {

        Intent intent = new Intent(activity,aClass) ;
        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK) ;
        activity.startActivity(intent) ;

    }

    @Override
    protected void onPause() {
        super.onPause();
        closeDrawer(drawerLayout);
    }
}