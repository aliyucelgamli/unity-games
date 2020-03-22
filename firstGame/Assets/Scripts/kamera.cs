using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public GameObject karakterRef;
    private Vector3 kameraKarakterMesafesi;

    void Start()
    {
        kameraKarakterMesafesi = transform.position - karakterRef.transform.position;
    }


    void Update()
    {

    }

    void LateUpdate()
    {
        transform.position = karakterRef.transform.position + kameraKarakterMesafesi;
    }
}
