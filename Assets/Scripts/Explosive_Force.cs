using UnityEngine;
using System.Collections;

public class Explosive_Force : MonoBehaviour {
    public float radius = 5.0f;
    public float power = 10.0f;
    public int timer = 0;
    private Vector3 explosivePos;
    private Rigidbody rb;
    private Collider[] colliders;
    // Use this for initialization
    void Start () {
        explosivePos = transform.position;
        colliders = Physics.OverlapSphere(explosivePos, radius);
   
	}
	
	// Update is called once per frame
	void Update () {
        if (timer >= 100)
        {
            foreach (Collider hit in colliders)
            {
                rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                    rb.AddExplosionForce(power, explosivePos, radius, 3.0f);
            }
        }
        ++timer;
        
    }
}
