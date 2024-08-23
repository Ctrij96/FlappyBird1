using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootHandler : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _firePoint;

    private void OnEnable()
    {
        StartCoroutine(StartShooting());
    }

    private void Shoot()
    {
        Bullet bullet = Instantiate(_bullet, _firePoint.position, transform.rotation);
        bullet.Shoot(transform.right);
    }

    private IEnumerator StartShooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Shoot();
        }
    }

}
