using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour 
{
    List<Vector3> _positions;

    public GameObject EnemyPrototype;

	void Awake() 
    {
        _positions = new List<Vector3>();
        for(int i=0;i<transform.childCount;i++)
            _positions.Add(transform.GetChild(i).position);

        StartCoroutine(SpawnCoroutine());
	}

    IEnumerator SpawnCoroutine()
    {
        float spawnTime = 3f;

        while(true)
        {
            yield return new WaitForSeconds(spawnTime);

            spawnTime -= 0.1f;

            int idx = Random.Range(0, _positions.Count);
            Instantiate(EnemyPrototype, _positions[idx], Quaternion.identity);
        }
    }
}
