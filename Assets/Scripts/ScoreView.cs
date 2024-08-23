using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private ScoreCounter _scoreCounter;
    [SerializeField] private TextMeshProUGUI _scoreView;

    private void Start()
    {
        _scoreCounter.ScoreChanged += ChangeScore;
    }

    private void ChangeScore(float score)
    {
        _scoreView.text = score.ToString();
    }
}
