using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarSceneTres : MonoBehaviour
{

    // Update is called once per frame
    //Entienda que cuando este drentro de un colider la escena cambie
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Donde (Hello) = Nombre de la Escena
            SceneManager.LoadScene("ThirdScene");
        }
    }
}
