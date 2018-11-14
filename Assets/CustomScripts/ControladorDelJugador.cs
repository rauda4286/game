using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour
{
    int contador;
    Rigidbody rb;
    public Text puntuacion;
    public float velocidad;
    public Text win;
    public GameObject door;
    public GameObject speed;
    public GameObject other2;


    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        actualizarmarcador();

        if (gameObject.name == "Ship")  // if the objects touch 

        {
            other2.SetActive(false);
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();  // plays sound when collided.
        }



            if (contador >= 3)
        {
            win.gameObject.SetActive(true);
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
