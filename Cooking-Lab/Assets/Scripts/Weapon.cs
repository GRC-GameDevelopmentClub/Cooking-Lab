using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform shootingPoint;
    public float fireRate = 0;
    public float damage = 10;
    public Transform BulletTrailPrefab;

    private bool justShot;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (!justShot)
            {
                Shoot();
            }
        }

        if (justShot)
        {
            fireRate += Time.deltaTime;
            if (fireRate >= 0.5)
            {
                fireRate = 0f;
                justShot = false;
            }
        }
    }

    void Shoot()
    {
        Instantiate(BulletTrailPrefab, shootingPoint.position, shootingPoint.rotation);
        justShot = true;
    }

}
