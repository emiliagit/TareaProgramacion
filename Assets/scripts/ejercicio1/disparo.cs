using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public GameObject ProyectilPRefab;
    public Transform proyectilSpawnPint;
    public float proyectilSpeed = 13f;

    private float nextAttackTime = 0f;
    public float attackSpeed = 2f;




    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextAttackTime)
        {
            Shoot();
            nextAttackTime = Time.time + 1f / attackSpeed;

        }
    }


    public void Shoot()
    {

        Vector3 shootDirection = proyectilSpawnPint.forward;


        GameObject projectile = Instantiate(ProyectilPRefab, proyectilSpawnPint.position, Quaternion.LookRotation(shootDirection));
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        projectileRb.velocity = shootDirection * proyectilSpeed;
        Destroy(projectile, 3f);
    }
}
