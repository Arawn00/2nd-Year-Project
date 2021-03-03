using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Rigidbody projectile;
    public Transform spawnpoint;
    public float projectilespeed = 100.0f;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
        Rigidbody projectileInstance;
        projectileInstance= Instantiate(projectile,spawnpoint.position,spawnpoint.rotation) as Rigidbody;
        projectileInstance.AddForce(Vector3.forward*projectilespeed);
        }
    }
}