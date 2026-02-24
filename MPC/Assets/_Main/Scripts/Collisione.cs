using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collisione : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D collisions)
    {

        Debug.Log("Estoy tocando Algo");
        }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("On collision exit");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("On Collision Stay");
    }

}