using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedCamera : MonoBehaviour {

    public GameObject ToLink;
    public Vector3 Offset;
    public float Delay;

    // Use this for initialization
    void Start () {
        this.Offset = new Vector3(0, 0, -10);
    }
	
	// Update is called once per frame
	void Update () {

        if (ToLink == null)
            return;

        var wanted = this.ToLink.transform.position + (this.ToLink.transform.rotation * this.Offset);
        var current = Vector3.Lerp(this.transform.position, wanted, this.Delay * Time.deltaTime);
        var rotation = Quaternion.LookRotation(this.ToLink.transform.position - this.transform.position, Vector3.up);

        this.transform.position = current;
        this.transform.rotation = rotation;
    }

    public void ZoomIn()
    {

    }

    public void ZoomOut()
    {

    }
}
