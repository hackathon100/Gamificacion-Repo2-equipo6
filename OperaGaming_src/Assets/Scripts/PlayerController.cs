using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public static string plataformaActual;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("plataformaActual:" + plataformaActual);
    }





    private void OnCollisionEnter(Collision collision)
    {
        plataformaActual = collision.gameObject.tag;

    }
    // private void OnCollisionStay(Collision collision)
    // {
    //     Debug.Log("OnCollisionStay");
    //     if (gameObject.CompareTag("Cube4"))
    //     {
    //         Debug.Log("Cubo4");
    //     }
    // }


    //     void OnTriggerEnter(Collider obj){ // turn message on when player is inside the trigger if (obj.tag == "Player") guiOn = true; }

    // void OnTriggerExit(Collider obj){ // turn message off when player left the trigger if (obj.tag == "Player") guiOn = false; }


    //     private void OnTriggerEnter(Collider other)
    // {

    //     Debug.Log("a1");
    //     if (gameObject.CompareTag("Player"))
    //     {
    //         Debug.Log("HIT");
    //     }


    // }
}


