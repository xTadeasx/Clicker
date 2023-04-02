using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hra_main : MonoBehaviour
{
    //vezi z unity
    public TextMeshProUGUI score_text;
    public TextMeshProUGUI Button_cena_click;
    public TextMeshProUGUI Button_cena_cerv;
    public TextMeshProUGUI Button_cena_farmar;
    public TextMeshProUGUI Button_cena_farma;
    public TextMeshProUGUI Button_cena_tovarna;

    public GameObject Button_double;
    public GameObject Button_vorm_tick;
    // Zaklad
    int coin;
    float timePassed_cerv = 0f;
    float timePassed_farmar = 0f;
    float timePassed_farma = 0f;
    float timePassed_tovarna = 0f;
    float docasna;
    int click = 1;

    //cena Tezicky
    int cena_click = 10;
    int cena_cerv = 10;
    int cena_farmar = 50;
    int cena_farma = 100;
    int cena_tovarna = 500;

    //pocet Tezicek
    int cerv = 0;
    int farmar = 0;
    int farma = 0;
    int tovarna = 0;

    //Upgrady
    bool upgrade_double_click = false;
    float upgrade_vorm = 0f;

    //Mack
    public void Button_mack(){
        coin += click;
        if (upgrade_double_click) {
            coin += click;
        }
        score_text.text = coin+"$";
    }

    //Tezicky
    public void buy_click_upgrade() {
        if (coin >= cena_click){
            click++;
            coin -= cena_click;
            docasna = ((float)(cena_click * 1.5));
            cena_click = (int)docasna;
            score_text.text = coin+"$";
            Button_cena_click.text = cena_click+"$";
        }
    }
    public void buy_cerv() {
        if (coin >= cena_cerv){
            cerv++;
            coin -= cena_cerv;
            docasna = ((float)(cena_cerv * 1.5));
            cena_cerv = (int)docasna;
            score_text.text = coin+"$";
            Button_cena_cerv.text = cena_cerv+"$";
        }
    }
    public void buy_farmar() {
        if (coin >= cena_farmar){
            farmar++;
            coin -= cena_farmar;
            docasna = ((float)(cena_farmar * 1.5));
            cena_farmar = (int)docasna;
            score_text.text = coin+"$";
            Button_cena_farmar.text = cena_farmar+"$";
        }
    }
    public void buy_farma() {
        if (coin >= cena_farma){
            farma++;
            coin -= cena_farma;
            docasna = ((float)(cena_farma * 1.5));
            cena_farma = (int)docasna;
            score_text.text = coin+"$";
            Button_cena_farma.text = cena_farma+"$";
        }
    }
    public void buy_tovarna() {
        if (coin >= cena_tovarna){
            tovarna++;
            coin -= cena_tovarna;
            docasna = ((float)(cena_tovarna * 1.5));
            cena_tovarna = (int)docasna;
            score_text.text = coin+"$";
            Button_cena_tovarna.text = cena_tovarna+"$";
        }
    }

    //Upgrades
    public void Upgrade_double_click(){
        if (coin >= 1) {
            upgrade_double_click = true;
            coin -= 1;
            Destroy(Button_double);
        }
    }

    public void Upgrade_vorm_tick(){
        if (coin >= 1) {
            upgrade_vorm = 0.5f;
            coin -= 1;
            Destroy(Button_vorm_tick);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        score_text.text = coin+"$";
        Button_cena_click.text = cena_click+"$";
        Button_cena_cerv.text = cena_cerv+"$";
        Button_cena_farmar.text = cena_farmar+"$";
        Button_cena_farma.text = cena_farma+"$";
        Button_cena_tovarna.text = cena_tovarna+"$";
        
    }

    // Update is called once per frame
    void Update()
    {
        //pouzity Tezizek
        if (cerv >= 1) {
            timePassed_cerv += Time.deltaTime;
            if(timePassed_cerv >= 2f-upgrade_vorm){
                coin = coin + (2*cerv);
                score_text.text = coin+"$";
                timePassed_cerv = 0;
            }
        }
        if (farmar >= 1) {
            timePassed_farmar += Time.deltaTime;
            if(timePassed_farmar >= 2f){
                coin = coin + (5*farmar);
                score_text.text = coin+"$";
                timePassed_farmar = 0;
            }
        } 
        if (farma >= 1) {
            timePassed_farma += Time.deltaTime;
            if(timePassed_farma >= 2f){
                coin = coin + (10*farma);
                score_text.text = coin+"$";
                timePassed_farma = 0;
            }
        }
        if (tovarna >= 1) {
            timePassed_tovarna += Time.deltaTime;
            if(timePassed_tovarna >= 2f){
                coin = coin + (50*tovarna);
                score_text.text = coin+"$";
                timePassed_tovarna = 0;
            }
        }       
    }
}
