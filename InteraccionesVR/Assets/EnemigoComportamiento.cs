using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoComportamiento : MonoBehaviour
{
    //Variables

    public float rangoDeAlerta;

    public LayerMask capaDelJugador;

    bool dentroRango;

    public Transform jugador;
    public float velocidad;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dentroRango = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);

        if (dentroRango)
        {
            Vector3 posJugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
            transform.LookAt(posJugador);
            transform.position = Vector3.MoveTowards(transform.position, posJugador, velocidad * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }
}
