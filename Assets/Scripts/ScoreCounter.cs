using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private float _score = 0;

    public event Action<float> ScoreChanged;

    public void AddScore()
    {
        _score += 5f;
        ScoreChanged?.Invoke(_score);
    }

    public void Reset()
    {
        _score = 0f;
        ScoreChanged?.Invoke(_score);
    }
}
