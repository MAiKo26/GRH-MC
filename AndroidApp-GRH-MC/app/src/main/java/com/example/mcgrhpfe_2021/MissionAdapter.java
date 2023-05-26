package com.example.mcgrhpfe_2021;

import android.app.Dialog;
import android.content.Context;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import java.util.List;


public class MissionAdapter extends RecyclerView.Adapter<MissionAdapter.MissionViewHolder> {

    private Context mCtx;
    private List<Mission> MissionList;
    Mission Mission ;

    private static final String TAG = "MissionAdapter";


    public MissionAdapter(Context mCtx, List<Mission> MissionList){
        this.mCtx = mCtx ;
        this.MissionList = MissionList ;

    }

    public class MissionViewHolder extends RecyclerView.ViewHolder {

        TextView Textview , Textview2 ;

        LinearLayout parentLayout ;

        public MissionViewHolder(View itemView) {
            super(itemView);


            Textview = itemView.findViewById(R.id.textViewCM01);
            Textview2 = itemView.findViewById(R.id.textViewLM02);
            parentLayout = itemView.findViewById(R.id.parent_layoutM) ;


        }
    }


    @Override
    public MissionViewHolder onCreateViewHolder( ViewGroup parent, int i) {
        Log.d(TAG, "onCreateViewHolder: 1");
        LayoutInflater inflater = LayoutInflater.from(mCtx) ;
        Log.d(TAG, "onCreateViewHolder: 2");

        View view = inflater.inflate(R.layout.recyclerview_mission, null);
        Log.d(TAG, "onCreateViewHolder: 3");

        MissionAdapter.MissionViewHolder holder = new MissionAdapter.MissionViewHolder(view) ;
        Log.d(TAG, "onCreateViewHolder: 4");

        return holder ;    }

    @Override
    public void onBindViewHolder(MissionViewHolder holder, int i) {


        Mission = MissionList.get(i) ;
        Log.d(TAG, "onBindViewHolder: 1");
        holder.Textview.setText(Mission.getCodemission());
        Log.d(TAG, "onBindViewHolder: 2");

        holder.Textview2.setText(Mission.getLibelle());
        Log.d(TAG, "onBindViewHolder: 3");

        holder.parentLayout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Mission MissionDetail;
                MissionDetail = MissionList.get(holder.getAdapterPosition()) ;

                Intent intent = new Intent(mCtx, MissionDetail.class);
                intent.putExtra("CodeM", (MissionDetail.getCodemission()));
                intent.putExtra("Libelle", (MissionDetail.getLibelle()));
                intent.putExtra("Type", (MissionDetail.getType()));
                intent.putExtra("Info1", (MissionDetail.getInfo1()));
                intent.putExtra("Info2", (MissionDetail.getInfo2()));
                intent.putExtra("Info3", (MissionDetail.getInfo3()));


                mCtx.startActivity(intent);

            }
        });

    }

    @Override
    public int getItemCount() { return MissionList.size() ;    }


}
