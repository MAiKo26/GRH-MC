package com.example.mcgrhpfe_2021;


import android.app.Dialog;
import android.content.Context;

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

public class PartenaireAdapter extends RecyclerView.Adapter<PartenaireAdapter.PartenaireViewHolder> {

    class PartenaireViewHolder extends RecyclerView.ViewHolder {

        TextView Textview , Textview2 ;

        LinearLayout parentLayout ;


        public PartenaireViewHolder(View itemView) {
            super(itemView);

            Textview = itemView.findViewById(R.id.textViewCP01);
            Textview2 = itemView.findViewById(R.id.textViewNP02);
            parentLayout = itemView.findViewById(R.id.parent_layoutP) ;

        }

    }


    private Context mCtx;
    private List<Partenaire> PartenaireList;
    Partenaire Partenaire ;

    private static final String TAG = "PartenaireAdapter";

    public PartenaireAdapter(Context mCtx, List<Partenaire> PartenaireList){
        this.mCtx = mCtx ;
        this.PartenaireList = PartenaireList ;

    }



    @Override
    public PartenaireViewHolder onCreateViewHolder(ViewGroup parent, int i) {
        Log.d(TAG, "onCreateViewHolder: 1");
        LayoutInflater inflater = LayoutInflater.from(mCtx) ;
        Log.d(TAG, "onCreateViewHolder: 2");

        View view = inflater.inflate(R.layout.recyclerview_partenaire, null);
        Log.d(TAG, "onCreateViewHolder: 3");

        PartenaireViewHolder holder = new PartenaireViewHolder(view) ;
        Log.d(TAG, "onCreateViewHolder: 4");

        return holder ;

    }

    @Override
    public void onBindViewHolder(PartenaireViewHolder holder, int i) {

        Partenaire = PartenaireList.get(i) ;
        Log.d(TAG, "onBindViewHolder: 1");
        holder.Textview.setText(Partenaire.getCodePartenaire());
        Log.d(TAG, "onBindViewHolder: 2");

        holder.Textview2.setText(Partenaire.getNom());
        Log.d(TAG, "onBindViewHolder: 3");

        holder.parentLayout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Partenaire PartenaireDetail;
                PartenaireDetail = PartenaireList.get(holder.getAdapterPosition()) ;

                 Intent intent = new Intent(mCtx, PartenaireDetail.class);
                intent.putExtra("CodeP", (PartenaireDetail.getCodePartenaire()));
                intent.putExtra("Type", (PartenaireDetail.getType()));
                intent.putExtra("Adresse", (PartenaireDetail.getAdresse()));
                intent.putExtra("Nom", (PartenaireDetail.getNom()));
                intent.putExtra("Mobile", (PartenaireDetail.getMobile()));
                intent.putExtra("Telephone", (PartenaireDetail.getTelephone()));
                intent.putExtra("Ville", (PartenaireDetail.getVille()));
                intent.putExtra("Pays", (PartenaireDetail.getPays()));
                intent.putExtra("Info1", (PartenaireDetail.getInfo1()));
                intent.putExtra("Info2", (PartenaireDetail.getInfo2()));
                intent.putExtra("Info3", (PartenaireDetail.getInfo3()));


                mCtx.startActivity(intent);

            }
        });
    }

    @Override
    public int getItemCount() {
        return PartenaireList.size();
    }
}
