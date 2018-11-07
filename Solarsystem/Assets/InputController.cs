using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        var rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.UpArrow))
        {           
            rb.AddForce(this.transform.rotation * Vector3.up);         
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3();
            rb.angularVelocity = new Vector3();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.SendMessage("Zoomout");
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.SendMessage("Zoomin");
        }

    }
}
