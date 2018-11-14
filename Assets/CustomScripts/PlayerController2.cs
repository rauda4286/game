using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour {

    int contador;
    Rigidbody rb;
    public Text puntuacion;
    public float velocidad;
    public Text win;
    public GameObject door;


    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        actualizarmarcador();
        if (contador >= 5)
        {
            //win.gameObject.SetActive(true);
            door.gameObject.SetActive(true);
        }//else if(contador == 2)
         //{
         //  speed.gameObject.SetActive(true);
         //}


    }

    private void actualizarmarcador()
    {
        puntuacion.text = "Puntuacion: " + contador;
    }

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        actualizarmarcador();
        win.gameObject.SetActive(false);

    }

    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }
}
