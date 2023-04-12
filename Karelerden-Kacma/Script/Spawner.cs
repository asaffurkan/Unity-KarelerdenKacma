using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Oluşturulacak prefab nesnesinin referansı
    public GameObject _prefab;

    // Oluşturulacak prefab nesneleri arasındaki süre
    public float _duration;

    // Son prefab oluşturulmasından bu yana kalan süre
    private float _time;

    // Rasgele alanı belirttiğimiz alanda nesne oluşçak
    public float _minX;
    public float _maxX;

    void Update()
    {
        // Zaman 0'dan küçükse ve ya eşitse yeni bir prefab oluşturur
        if (_time <= 0)
        {
            _time = _duration;
            Spawn();
        }
        // Süreyi Senkronize eder
        else
        {
            _time -= Time.deltaTime;
        }
    }

    
    public void Spawn()
    {
        GameObject instance = Instantiate(_prefab);

        // rasgele konumda nesne spawnlar
        instance.transform.position = new Vector2(
            Random.Range(_minX, _maxX),
            transform.position.y
        );

        instance.transform.SetParent(transform);
    }
}
