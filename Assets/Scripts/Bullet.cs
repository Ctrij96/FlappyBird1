using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CollisionHandler))]

public class Bullet : MonoBehaviour, IInteractable
{
    [SerializeField] private float _bulletSpeed;

    private Rigidbody2D _rb2d;

    public void Interact()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

    public void Shoot(Vector2 direct)
    {
        _rb2d.AddForce(direct * _bulletSpeed);
        StartCoroutine(DestroyTimer());
    }
}
