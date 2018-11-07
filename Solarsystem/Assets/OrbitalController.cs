using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalController : MonoBehaviour {

    /// <summary>
    /// Stores the Position of the Object that each Planet will revolve around.
    /// </summary>
    public Transform Pivot;
    /// <summary>
    /// How fast each Planet revolves around the central Star.
    /// </summary>
    public float Speed;
    /// <summary>
    /// How Fast an object rotates around its own axis.
    /// </summary>
    public float Rotation;
    /// <summary>
    /// Represents aPlante-Radius compared to Earth.
    /// </summary>
    public float Radius;
    /// <summary>
    /// Is the distance in Astronomical Units (AU) from the central star.
    /// </summary>
    public float DistanceFromStar;
    
	// Use this for initialization
	void Start () {
        var randomPosition = Random.insideUnitCircle;
        transform.position = new Vector3(1, 0, 1) * DistanceFromStar;
        transform.localScale = Vector3.one * this.Radius;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(this.Pivot.position, Vector3.up, (this.Speed / (24 * 60 * 60)) * Time.deltaTime);
        this.transform.Rotate(Vector3.up, ((this.Rotation/(24*60*60)) * Time.deltaTime));

    }
}
