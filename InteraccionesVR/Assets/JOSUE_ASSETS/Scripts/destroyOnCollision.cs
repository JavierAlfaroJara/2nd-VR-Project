using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollision : MonoBehaviour
{
    public GameObject pared;
    public AudioSource seAbrePuerta;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "aquiVaElTalisman")
        {
            
            seAbrePuerta.Play();
            Destroy(pared.gameObject);
        }
    }

}
