using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanceColor : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;

	// Use this for initialization
	void Start () {

        cam1.enabled = true;
        cam2.enabled = false;

    }

    void OnMouseDown()
    {

        if (cam1.enabled)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        else
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }


    }

}
