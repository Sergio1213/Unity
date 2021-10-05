using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    private bool mirandoderecha=true;
    public float velocidad;

    private Rigidbody2D rigidBody;
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        movimiento();
    }
    void movimiento()
    {
        float inputmovimiento = Input.GetAxis("Horizontal");
       
        rigidBody.velocity = new Vector2(inputmovimiento * velocidad, rigidBody.velocity.y) ;
        GestionarOrientacion(inputmovimiento);
    }
    void GestionarOrientacion(float inputmovimiento)
    {
        if ((mirandoderecha=true && inputmovimiento<0)||(mirandoderecha=false && inputmovimiento>0))
        {
            mirandoderecha = !mirandoderecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
