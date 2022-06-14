using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class irSiguienteEscena : MonoBehaviour
{


    void OnCollisionEnter(Collision collision)
    {

        // Ir a la escena de fuego
        if(collision.gameObject.name == "irMenu")
        {
            print("De vuelta al menu");
            SceneManager.LoadScene(0);

        }
        else if (collision.gameObject.name == "irAEscenaDeFuego")
        {
            print("Vamonossss a la escena de fuego");
            SceneManager.LoadScene(1);

        }
        else if (collision.gameObject.name == "irAexplicacionFuego")
        {
            print("Ir a la escena de la explicacion de fuego");
            SceneManager.LoadScene(5);

        }
        else if (collision.gameObject.name == "Teletrasportador")
        {
            print("Ir a la escena explicacion cueva");
            SceneManager.LoadScene(8);

        } else if (collision.gameObject.name == "irEscenaCueva")
        {
            print("Ir a la escena de la cueva");
            SceneManager.LoadScene(2);

        }
        else if (collision.gameObject.name == "irExplicacionZombie")
        {
            print("Ir a la escena de la explicaci�n de zombies");
            SceneManager.LoadScene(7);

        }
        else if (collision.gameObject.name == "irEscenaZombie") 
        {
            print("Ir a la escena del Zombie");
            SceneManager.LoadScene(3);

        }
        else if (collision.gameObject.name == "escenaFinal")
        {
            print("Se pasa el juego y nos vamos a la escena final");
            SceneManager.LoadScene(4);

        }
        else if (collision.gameObject.name == "salirDelJuego")
        {
            print("Se quiere salir del juego");
            Application.Quit();

        }
        else if (collision.gameObject.name == "muerte")
        {
            print("Chale se muri�");
            SceneManager.LoadScene(6);

        } 
    }
}
