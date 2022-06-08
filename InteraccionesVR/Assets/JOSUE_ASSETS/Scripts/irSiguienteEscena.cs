using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class irSiguienteEscena : MonoBehaviour
{


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Teletrasportador")
        {
            print("Teletransportarse a otro lugar");
            SceneManager.LoadScene(1);
        }
    }
}
