using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide_door : MonoBehaviour {

    public GameObject door;

	// Use this for initialization
	void Start () {

            door.gameObject.SetActive(false);
       
    
    }

    // Update is called once per frame
    void Update () {
		
	}
}
