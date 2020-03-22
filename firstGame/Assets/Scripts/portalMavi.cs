using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalMavi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public float newX = 2;
    public float newY = 2;
    public float newZ = 2;
    public GameObject playerRef;
    
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PLAYER")
        {
           
        other.transform.position = playerRef.transform.position + new Vector3(newX, newY, newZ);

        }
    }

}
