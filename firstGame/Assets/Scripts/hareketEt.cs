using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketEt : MonoBehaviour
{

    public float gucKatsayisi;

    private Rigidbody rigidBodyRef;

    void Start()
    {
        rigidBodyRef = GetComponent<Rigidbody>();

    }

    void Update()
    {

    }

    //fizik hesaplamaları yapılmadan önce yapılacaklar
    void FixedUpdate()
    {
        rigidBodyRef.AddForce(
            Input.GetAxis("Horizontal") * gucKatsayisi,
            0f,
            Input.GetAxis("Vertical") * gucKatsayisi);

    }
}
