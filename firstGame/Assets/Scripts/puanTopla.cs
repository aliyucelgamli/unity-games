using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puanTopla : MonoBehaviour { 

    public int toplananPuanMiktari;
    public Text yaziUI;
    
    void Start()
    {
    toplananPuanMiktari = 0;
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
{


    toplananPuanMiktari++;
    yaziUI.text = " "+ toplananPuanMiktari;
    
    
       print("Puan:" + toplananPuanMiktari);

    }
    
}
