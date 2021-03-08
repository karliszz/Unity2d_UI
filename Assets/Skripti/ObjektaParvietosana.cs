using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//importe lai lietotu pointer darbibu interfeisu
//papildus ir japarliecinas ka projkekta pie canvas ir importeta eventsystems UI koponente
using UnityEngine.EventSystems;

//piesaista pointer interfeisu 
public class ObjektaParvietosana : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform transformacijuLogs;
    public Canvas kanva;

    private void Awake()
    {
        transformacijuLogs = GetComponent<RectTransform>();
    }

    //funcija nostrada, kad uzkliksķina uz parvietojama objekta
    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Kreisais kliksķis uz parvietojama objekt!");
    }

    //funkcija nostarada uzsakot parvietosanu
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsak parvietosanu!");
    }

    //Funkcija nostarada parvietosanas bridi
    public void OnDrag(PointerEventData notikums)
    {
        transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }

    //funkcija nostarada atlaizot
    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Vilksana pabeigta!");
    }
}
