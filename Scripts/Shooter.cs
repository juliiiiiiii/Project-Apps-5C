using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject bullet;

    public Transform firePoint;

    public float bulletForce = 20f;

    void Update()
    {
        //GunRotate
        

        if(Input.GetButtonDown("Fire1"))
        {
            shooting();
        }

    }

    void shooting()
    {
        GameObject shoot = Instantiate(bullet, firePoint.position, firePoint.rotation);
        Destroy(shoot, .5f);
    }

}
