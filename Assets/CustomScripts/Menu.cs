using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {


    public void Jugar(string LevelName)
    {
        Application.LoadLevel("SampleScene");
    }
    public void Salir()
    {
        Application.Quit();
    }



}
