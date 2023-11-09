using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{

    public int velocGiro = 50;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Player"){
            FindObjectOfType<GameManager>().SubtrairMoedas(1);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(eulers:Vector3.up * velocGiro * Time.deltaTime,relativeTo:Space.World);
    }
}
