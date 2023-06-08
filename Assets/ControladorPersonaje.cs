using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    protected string nombre;
    static double dinero;
    
    public float speed;
    private bool estado;
    public float moveForce;

    bool isSliding = false;
    GameObject go;
    public Transform target;
    Animator anim;
    public Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        nombre = "Personaje";
        speed = 0.4f;
        dinero = 123123.4234;
        estado = true;
        moveForce = 1;

        target = GetComponent<Transform>();
        anim = GetComponent<Animator>();


        Debug.Log("Hola Mundo, " + nombre + " tiene una velocidad de " + speed);
        imprimitNombre();
        Debug.Log("position " + target.position);
        Debug.Log("local position " + target.localPosition);

    }

    void Update()
    {
        speed = Input.GetAxis("Horizontal");

        //if (speed != 0)
        //{
        //    Debug.Log("Velocidad " + speed);
            
        //}
        anim.SetFloat("spped", Mathf.Abs(speed));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isSliding == false)
            {
                isSliding = true;
            }
            else
            {
                isSliding = false;
                rb.AddForce(new Vector3(0, 5, 0));

            }
            anim.SetBool("slide", isSliding);
        }


        rb.AddForce(new Vector3(1, 0, 0) * moveForce  * speed);

    }


    void imprimitNombre()
    {
        Debug.Log("" + nombre + " con dinero:" + dinero + " y con velocidad de:" + speed);
    }


}
