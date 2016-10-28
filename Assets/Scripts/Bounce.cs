using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

    public Rigidbody rb;
    private bool bounce = false;
    public float bounceAmount = 10;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();   
	}
	
    void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * bounceAmount);
    }
	// Update is called once per frame
	void Update () {

	}
}
