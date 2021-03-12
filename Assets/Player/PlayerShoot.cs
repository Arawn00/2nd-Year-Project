using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnpoint;
    public float projectilespeed = 100.0f;
    public Camera camera;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
        GameObject projectile = Instantiate(bullet,spawnpoint.position,spawnpoint.rotation);
        Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();
        projectileRigidbody.AddForce(camera.transform.forward*projectilespeed);
        }
    }
}
