using System;
using UnityEngine;
using UnityEngine.Rendering;

public class MuevePersonaje : MonoBehaviour
{
    //Velocidad
    public float VelocidadX;

    [SerializeField]  //Permiso a Unity de acceder a la variable

    private float VelocidadY;

    // Rigidbody para usar la física

    private Rigidbody2D rb;

    //Rerencia al Animator


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0) {
        rb.linearVelocity = new Vector2(movHorizontal*VelocidadX, movVertical*VelocidadY);
    } else {
        rb.linearVelocity = new Vector2(movHorizontal*VelocidadX, rb.linearVelocityY);
    }
    //Animator
   
    //Dirección del Personaje

}
    //Se llama automatiamente cuando la capsula traspasa otro colider
    
}
