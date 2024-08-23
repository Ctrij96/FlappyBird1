using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private Transform _container;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _upperBound;
    [SerializeField] private float _lowerBound;
    [SerializeField] private float _delay;
    [SerializeField] private ScoreCounter _counter;

    public ObjectPool<GameObject> EnemyPool;

    private void Awake()
    {
        EnemyPool = new ObjectPool<GameObject>(createFunc: () => Instantiate(_enemyPrefab, _container),
            actionOnGet: (obj) => ActionOnGet(obj),
            actionOnRelease: (obj) => obj.gameObject.SetActive(false),
            actionOnDestroy: (obj) => Destroy(obj.gameObject),
            defaultCapacity: 3,
            maxSize: 7);

        StartCoroutine(GenerateEnemies());
    }

    private void ActionOnGet(GameObject obj)
    {
        float spawnPosY = Random.Range(_upperBound, _lowerBound);
        obj.transform.position = new Vector2(transform.position.x, spawnPosY);
        obj.SetActive(true);
    }

    private IEnumerator GenerateEnemies()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_delay);
            EnemyPool.Get();
        }
    }

}
