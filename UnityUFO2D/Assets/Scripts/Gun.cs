using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public Transform muzzle;
    public Projectile projectile;
    public float msBetweenShots = 100f;
    public float muzzleVelocity = 35f;

    float nextShotTime;


    public void Shoot()
    {
        if (Time.time > nextShotTime)
        {
            nextShotTime = Time.time + msBetweenShots / 100;
            Projectile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
            newProjectile.SetSpeed(muzzleVelocity);

            Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

            newProjectile.GetComponent<Rigidbody2D>().velocity = dir.normalized * 10f;
        }
        
    }
}
