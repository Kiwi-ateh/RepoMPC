using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rb2D;
    [SerializeField] private float x = 0;
    public float velocidad = 10f;




    private void Start()
    {

        }

   
  private void FixedUpdate()
  {


        x += 0.01f;
        _rb2D.velocity =  Vector2.right* velocidad;
   //   x += 0.01f;
  //    _transform.position = new Vector3(-9.35f, -1.89f,0f);


 }




}
