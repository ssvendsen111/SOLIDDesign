using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile: MonoBehaviour {

    private Transform shootpoint;
    private float fireSpeed;
    private Projectile projectilePrefab;

    public void Awake()
    {
        this.shootpoint = gameObject.GetComponent<Weapon>().shootpoint;
        this.fireSpeed = gameObject.GetComponent<Weapon>().fireSpeed;
        this.projectilePrefab = gameObject.GetComponent<Weapon>().projectilePrefab;
    }
    public void Shoot()
    {
        var spawnedProjectile = Instantiate(projectilePrefab, shootpoint.position, shootpoint.rotation);
        spawnedProjectile.Fire(fireSpeed, transform.forward);
    }

}
