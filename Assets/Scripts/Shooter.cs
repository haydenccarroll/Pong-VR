using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;

    public Transform shotPosLeft;
    public Transform shotPosRight;
    public float shotForce = 1000f;
    public float moveSpeed = 10f;
    public bool isThereBall = false;


    public void OnSpawnBallLeft()
    {
        if (!isThereBall) 
        {
            Rigidbody shot = Instantiate(projectile, shotPosLeft.position, shotPosLeft.rotation) as Rigidbody;
            shot.AddForce(shotPosLeft.forward * shotForce);
            isThereBall = true;
        }
    }

    public void OnSpawnBallRight()
    {
        if (!isThereBall) 
        {
            Rigidbody shot = Instantiate(projectile, shotPosRight.position, shotPosRight.rotation) as Rigidbody;
            shot.AddForce(shotPosRight.forward * shotForce);
            isThereBall = true;
        }
    }

    
}
