using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 100f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire2();
        }
    }

    private void Fire2()
    {
        // Create the Bullet from the Bullet Prefab
        for (int i = -1; i <= 1; i++)
        {
            Quaternion rotation = bulletSpawn.rotation * Quaternion.Euler(0, 20*i, 0);
            Vector3 position = bulletSpawn.transform.position;
            position.x = position.x + i;
            var bullet = (GameObject) Instantiate(
                bulletPrefab,
                position,
                rotation);

            // Add velocity to the bullet
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

            // Destroy the bullet after 5 seconds
            Destroy(bullet, 5f);
        }
    }

    private void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        // Destroy the bullet after 5 seconds
        Destroy(bullet, 5f);
    }
}
