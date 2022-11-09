package com.example.exam_test;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    EditText txt_yas;
    TextView txt_goster;
    Button butonGoster;
    RadioGroup radioGroup;
    RadioButton radioButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txt_yas = findViewById(R.id.txtYas);
        txt_goster = findViewById(R.id.txtGoster);
        butonGoster = findViewById(R.id.btnGoster);
        radioGroup = findViewById(R.id.radioGroup);

    }

    public void Goster(View view){



    }

    public void secim(View view) {
        String sonuc ="";
        int yas= Integer.parseInt( txt_yas.getText().toString());
        int selectedId=radioGroup.getCheckedRadioButtonId();
        radioButton=(RadioButton)findViewById(selectedId);
        CharSequence text = radioButton.getText();

        if ("Erkek".equals(text)) {
            if (yas > 18)
                sonuc = "Ehliyet alabilir.";
            else
                sonuc = "Ehliyet alamaz";
        } else if ("Kız".equals(text)) {
            if (yas > 20)
                sonuc = "Ehliyet alabilir.";
            else
                sonuc = "Ehliyet alamaz";
        }

        txt_goster.setText(sonuc.toString());

    }
}