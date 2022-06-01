using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientodesalto : MonoBehaviour
{

    public GameObject salto;
    // Start is called before the first frame update


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "JumpTeleport")
        {
            this.gameObject.transform.Translate(new Vector3(salto.transform.position.x, salto.transform.position.y + 0.20f, salto.transform.position.z));
        }
    }
}
