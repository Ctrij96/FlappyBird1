using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootHandler : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _firePoint;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        Bullet bullet = Instantiate(_bullet, _firePoint.position, transform.rotation);
        bullet.Shoot(transform.right);
    }
}
