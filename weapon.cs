using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class weapon : MonoBehaviour
{
    
    protected Transform firePoint;
   
    protected GameObject bullet;

    protected float fireRate = 30f;
    protected float bulletSpeed = 30f;
    protected float damage = 10f;
    protected LayerMask whatToHit;
    protected LayerMask notToHit;
    protected float timeToFire = 0f;

    public void Shoot()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        Vector2 aim = firePointPosition + mousePosition;

        GameObject Projectile = Instantiate(bullet, firePointPosition, Quaternion.identity); //check this later for bugs

    }
    
    

}
