using UnityEngine;
using System.Collections;

public class Add_Acceleration : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	//if (Input.GetMouseButtonDown(0))
 //       {
 //           rb.velocity = new Vector3(Random.value, 20, Random.value);
 //       }
	}
}
