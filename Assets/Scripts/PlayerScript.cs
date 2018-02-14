using UnityEngine;
using System.Collections;
using CnControls;

public class PlayerScript : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void FixedUpdate() {
        Vector2 movement = new Vector2(CnInputManager.GetAxis("Horizontal"), CnInputManager.GetAxis("Vertical"));
        rb.AddForce(movement*speed, ForceMode2D.Impulse);
        
    }
}
