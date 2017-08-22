using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChanceTransparancy : MonoBehaviour {

    public GameObject go;
    public Scrollbar sb;
    private float value = 0.0f;
	// Use this for initialization
	void Start () {
        go.GetComponent<MeshRenderer>().material.color = new Color(go.GetComponent<MeshRenderer>().material.color.r, go.GetComponent<MeshRenderer>().material.color.g, go.GetComponent<MeshRenderer>().material.color.b, 0.0f);

    }

    // Update is called once per frame
    void Update () {
		
	}
    public void ChanceTrans()
    {
        if(value<1.0)
            go.GetComponent<MeshRenderer>().material.color = new Color(go.GetComponent<MeshRenderer>().material.color.r, go.GetComponent<MeshRenderer>().material.color.g, go.GetComponent<MeshRenderer>().material.color.b, 0.0f + sb.value);

    }
}
