using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject Bullet;
    public Transform BulletSpawnPoint;
    public float BulletSpeed;

    void Update()
    {
        disparos();
    }

    void disparos()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var Bala = Instantiate(Bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            Bala.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * BulletSpeed;
        }
    }
}
