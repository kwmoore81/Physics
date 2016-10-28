using UnityEngine;
using System.Collections;

public class LaserController : MonoBehaviour
{

    LineRenderer line;
    CursorLockMode wantedMode;
    public float laserForce = 10;
    public float laserMaxDistance = 100;
    Renderer renderer;
    ParticleSystem ps;
    ParticleSystem.EmissionModule em;
    Renderer rend;
    int gun = 1;
    // Use this for initialization
    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();
        line.enabled = false;
        renderer = gameObject.GetComponent<Renderer>();
        gameObject.GetComponent<Light>().enabled = false;
        ps = gameObject.GetComponent<ParticleSystem>();
        em = ps.emission;
        em.enabled = false;
        rend = ps.GetComponentInChildren<Renderer>();
        rend.enabled = false;
        //rend = gameObject.GetComponent<Renderer>().particleSystem;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
        {
            StopCoroutine("FireLaser");
            StartCoroutine("FireLaser");
        }

    }

    void GunType()
    {
        switch (gun)
        {
            case 5:
                ;
                break;
            case 4:
                ;
                break;
            case 3:
                ;
                break;
            case 2:
                ;
                break;
            case 1:
                ;
                break;
            default:
                ;
                break;

        }
    }

    void KineticBeam()
    {

    }


    IEnumerator FireLaser()
    {
        line.enabled = true;
        gameObject.GetComponent<Light>().enabled = true;
        em.enabled = true;
        rend.enabled = true;

        while (Input.GetButton("Fire1"))
        {

            renderer.material.mainTextureOffset = new Vector2(0, Time.time);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;


            line.SetPosition(0, ray.origin);

            if (Physics.Raycast(ray, out hit, laserMaxDistance))
            {
                line.SetPosition(1, hit.point);
                if (hit.rigidbody)
                {
                    hit.rigidbody.AddForceAtPosition(transform.forward * laserForce, hit.point);
                }
            }
            else
            {
                line.SetPosition(1, ray.GetPoint(laserMaxDistance));
            }
            yield return null;
        }

        while (Input.GetButton("Fire2"))
        {

            renderer.material.mainTextureOffset = new Vector2(0, Time.time);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;


            line.SetPosition(0, ray.origin);

            if (Physics.Raycast(ray, out hit, laserMaxDistance))
            {
                line.SetPosition(1, hit.point);
                if (hit.rigidbody)
                {
                    hit.rigidbody.AddForceAtPosition(-transform.forward * 10, hit.point);
                }
            }
            else
            {
                line.SetPosition(1, ray.GetPoint(laserMaxDistance));
            }
            yield return null;
        }
        line.enabled = false;
        gameObject.GetComponent<Light>().enabled = false;
        rend.enabled = false;
        em.enabled = false;


    }

} 
