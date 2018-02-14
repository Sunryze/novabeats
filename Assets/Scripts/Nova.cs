using UnityEngine;
using System.Collections;

public class Nova : MonoBehaviour {

    private Color colour;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(0.005f, 0.005f, 0);
	}
}
