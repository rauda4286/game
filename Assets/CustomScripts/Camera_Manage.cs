using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Manage : MonoBehaviour {
    public Vector3 targetOffset; //Seguimientoi de camara
    public Transform followtarget; //Distancia de camara
    public float movespeed = 2f; //velocidad de camara
    private Transform cameraTransform;

	// Use this for initialization
	void Start () {

        cameraTransform = transform; //Leemos cameraTranform


	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (followtarget != null)
            cameraTransform.position = Vector3.Lerp(cameraTransform.position, followtarget.position + targetOffset , movespeed*Time.deltaTime); //movimiento
	}


    public void setTarget(Transform _target)
    {
        followtarget = _target; //Estableciendo CustomTarget
    }


}
