using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//jaimporte lai varetu stradat ar ui
using UnityEngine.UI;
public class VardaParadisana : MonoBehaviour { 
    //Mainigaja saglabas tekstu ko raksta tekasta lauka
    public string teksts;
    //lauks, kura ierakta tekstu
    public GameObject ievadesLauks;
    //kur attelo tekstu
    public GameObject tekstaAttelosana;

    //funksija tiek izsaukta nospiezot pogu
    public void uzglabatTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Sveiks " + teksts.ToUpper() + "!";
    }

}
