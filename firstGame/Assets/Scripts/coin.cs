using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{

    public int puanlama;
    public Text yazi3UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "PLAYER")
        {
           
            other.GetComponent<playerScript>().puanMiktari++;
            puanlama = puanlama + 100;
            yazi3UI.text = " " + puanlama;
            Destroy(gameObject);
            
        }
    }
}
