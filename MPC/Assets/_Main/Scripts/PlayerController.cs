
using System.Globalization;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class PlayerController : MonoBehaviour


{


    [SerializeField] private bool _siLlueve = false;
    [SerializeField] private int _edad;
    [SerializeField] private Rigidbody2D _rb2D;
    [SerializeField] private int fuerzaSalto;
    [SerializeField] private bool isGround;


    private void Awake()
    {

        _rb2D = GetComponent<Rigidbody2D>();
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Tarea, hacer los movimientos con Get.Axist

        if (Input.GetButtonDown("Jump") && isGround == true)
        {

            _rb2D.AddForce(Vector2.up * fuerzaSalto);
        }



        /*

                if (_siLlueve == true && _edad >= 18)
                {
                    Debug.Log("Lleva sombrilla, debes votar");

                }

                else if (_siLlueve=true &&  _edad < 18)
                {

                    Debug.Log("empaca sombrilla, no puedes votar");

                }

            }

        */

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {

            isGround = true;
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {

            isGround = false;

        }
    }
}