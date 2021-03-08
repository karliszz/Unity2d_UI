using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    //uzglabā mūsu bildes no ainas
    public GameObject bins;
    public GameObject lacitis;
    public GameObject tante;
    public GameObject masina;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskano;

    public void binaAttelosana(bool vertiba)
    {
        bins.SetActive(vertiba);
    }

    public void lacisaAttelosana(bool vertiba)
    {
        lacitis.SetActive(vertiba);
    }

    public void tantesAttelosana(bool vertiba)
    {
        tante.SetActive(vertiba);
    }

    public void masinasAttelosana(bool vertiba)
    {
        masina.SetActive(vertiba);
    }

    public void paKreisiBins()
    {
        bins.transform.localScale = new Vector2(1, 1);
    }

    public void paLabiBins()
    {
        bins.transform.localScale = new Vector2(-1, 1);
    }

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        }else if (skaitlis == 1){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

        }else if (skaitlis == 2){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];

        }else if (skaitlis == 3){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[3];
        }
    }


    public void mainitLielumu()
    {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba);
    }

    public void uzbiditsUzAttels()
    {
        skanasAvots.PlayOneShot(skanaKoAtskano);
    }
    public void kursorsNobititsNoAttela()
    {
        skanasAvots.Stop();
    }


}