using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BirdMover))]
[RequireComponent(typeof(CollisionHandler))]
[RequireComponent(typeof(ShootHandler))]

public class Bird : MonoBehaviour, IInteractable
{
    [SerializeField] private BirdMover _birdMover;
    [SerializeField] private CollisionHandler _handler;

    public event Action GameOver;

    public void Interact()
    {
        // GameOver();
        Debug.Log("Геймовер");
    }

    public void Reset()
    {
        _birdMover.Reset();
    }
}
