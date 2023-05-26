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

public class EmployeAdapter extends RecyclerView.Adapter<EmployeAdapter.EmployeViewHolder> {

    class EmployeViewHolder extends RecyclerView.ViewHolder {

        TextView Textview , Textview2 ;

        LinearLayout parentLayout ;


        public EmployeViewHolder(View itemView) {
            super(itemView);

            Textview = itemView.findViewById(R.id.textViewCE01);
            Textview2 = itemView.findViewById(R.id.textViewNE02);

        }

    }


    private Context mCtx;
    private List<Employe> EmployeList;
    Employe Employe ;

    private static final String TAG = "EmployeAdapter";

    public EmployeAdapter(Context mCtx, List<Employe> EmployeList){
        this.mCtx = mCtx ;
        this.EmployeList = EmployeList ;

    }



    @Override
    public EmployeViewHolder onCreateViewHolder(ViewGroup parent, int i) {
        Log.d(TAG, "onCreateViewHolder: 1");
        LayoutInflater inflater = LayoutInflater.from(mCtx) ;
        Log.d(TAG, "onCreateViewHolder: 2");

        View view = inflater.inflate(R.layout.recyclerview_employe, null);
        Log.d(TAG, "onCreateViewHolder: 3");

        EmployeViewHolder holder = new EmployeViewHolder(view) ;
        Log.d(TAG, "onCreateViewHolder: 4");

        return holder ;

    }

    @Override
    public void onBindViewHolder(EmployeViewHolder holder, int i) {

        Employe = EmployeList.get(i) ;

        Log.d(TAG, "onBindViewHolder: 1");

        holder.Textview.setText(Employe.getCodeemploye());
        Log.d(TAG, "onBindViewHolder: 2");


        String NomComplet = Employe.getNom() + " " + Employe.getPrenom() ;

        holder.Textview2.setText(NomComplet);
        Log.d(TAG, "onBindViewHolder: 3");

       /* holder.parentLayout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                // ICI TRANSITION

            }
        });*/
    }

    @Override
    public int getItemCount() {
        return EmployeList.size();
    }
}
