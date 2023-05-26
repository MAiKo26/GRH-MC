package com.example.mcgrhpfe_2021;


import android.app.Dialog;
import android.content.Context;

import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import java.util.List;

public class MissionEmployeAdapter extends RecyclerView.Adapter<MissionEmployeAdapter.MissionEmployeViewHolder> {

    class MissionEmployeViewHolder extends RecyclerView.ViewHolder {

        TextView textview, textview2, textview3, textview4, textview5 ;

        LinearLayout parentLayout ;


        public MissionEmployeViewHolder(View itemView) {
            super(itemView);

            textview = itemView.findViewById(R.id.textView);
            textview2 = itemView.findViewById(R.id.textView2);
            textview3 = itemView.findViewById(R.id.textView3);
            textview4 = itemView.findViewById(R.id.textView4);
            textview5 = itemView.findViewById(R.id.textView5);
            parentLayout = itemView.findViewById(R.id.parent_layout) ;


        }
    }


    private Context mCtx;
    private List<MissionEmploye> MissionEmpList;
    MissionEmploye MissionEmp ;

    public MissionEmployeAdapter(Context mCtx, List<MissionEmploye> missionEmpList) {
        this.mCtx = mCtx;
        this.MissionEmpList = missionEmpList;
    }

    @Override
    public MissionEmployeViewHolder onCreateViewHolder(ViewGroup viewGroup, int i) {
        LayoutInflater inflater = LayoutInflater.from(mCtx);
        View view = inflater.inflate(R.layout.recyclerview_mission_affecte, null);
        MissionEmployeViewHolder holder = new MissionEmployeViewHolder(view);
        return holder;


    }

    @Override
    public void onBindViewHolder(MissionEmployeViewHolder holder, int i) {


        MissionEmp = MissionEmpList.get(i);
        holder.textview.setText(MissionEmp.getDatemission());
        holder.textview2.setText(MissionEmp.getCodemission());
        holder.textview3.setText(MissionEmp.getCodeemploye());
        holder.textview4.setText(MissionEmp.getCodepartenaire());
        holder.textview5.setText(MissionEmp.getObjet());


        holder.parentLayout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                 MissionEmploye MissionEmpDetail;
                 MissionEmpDetail = MissionEmpList.get(holder.getAdapterPosition()) ;

                Intent intent = new Intent(mCtx, MissionAffecteDetail.class);
                intent.putExtra("DateM", (MissionEmpDetail.getDatemission()));
                intent.putExtra("CodeM", (MissionEmpDetail.getCodemission()));
                intent.putExtra("CodeE", (MissionEmpDetail.getCodeemploye()));
                intent.putExtra("CodeP", (MissionEmpDetail.getCodepartenaire()));
                intent.putExtra("HA", (MissionEmpDetail.getHeurearrive()));
                intent.putExtra("HD", (MissionEmpDetail.getHeuredepart()));
                intent.putExtra("Adresse", (MissionEmpDetail.getAdresse()));
                intent.putExtra("Objet", (MissionEmpDetail.getObjet()));
                intent.putExtra("Unite", (MissionEmpDetail.getUnite()));
                intent.putExtra("PrixU", (MissionEmpDetail.getPrixu()));
                intent.putExtra("Info1", (MissionEmpDetail.getInfo1()));
                intent.putExtra("Info2", (MissionEmpDetail.getInfo2()));
                intent.putExtra("Info3", (MissionEmpDetail.getInfo3()));

                mCtx.startActivity(intent);

            }


        });





    }


    @Override
    public int getItemCount() {
        return MissionEmpList.size();
    }


}