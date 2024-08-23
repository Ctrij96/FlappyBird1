using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CollisionHandler))]

public class Enemy : MonoBehaviour, IInteractable
{
    [SerializeField] private ScoreCounter _scoreCounter;
    [SerializeField] private EnemyGenerator _enemyGenerator;
    [SerializeField] private Transform _firePoint;
    [SerializeField] private GameObject _bulletPrefab;

    private void Awake()
    {
        _enemyGenerator = FindAnyObjectByType<EnemyGenerator>();
        _scoreCounter = FindAnyObjectByType<ScoreCounter>();
    }
    public void Interact()
    {
        _scoreCounter.AddScore();
        Reset();
    }

    public void Reset()
    {
        _enemyGenerator.EnemyPool.Release(this.gameObject);
    }
}
