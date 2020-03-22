using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerScript : MonoBehaviour{

    public int puanMiktari;
    
    public Text yazi2UI;

    void Start()
    {

    }

    
    void Update()
    {

    }

    private void pickUp()
    {
       
        puanMiktari++;
        yazi2UI.text = " " + puanMiktari;
    }



}
