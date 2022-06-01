using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject saltoTecho;
    [SerializeField]
    private GameObject LlegadaEdi2;
    [SerializeField]
    private GameObject personaje;
  
    public void cargarEscena(int numescena)
    {

        SceneManager.LoadScene(numescena);

    }

    public void salirApp()
    {
        Application.Quit();
    }

    public void subirTecho()
    {
        personaje.transform.SetPositionAndRotation(saltoTecho.transform.position, saltoTecho.transform.rotation);
    }

    public void bajarTecho()
        {
            personaje.transform.SetPositionAndRotation(LlegadaEdi2.transform.position, LlegadaEdi2.transform.rotation);
        }
}
