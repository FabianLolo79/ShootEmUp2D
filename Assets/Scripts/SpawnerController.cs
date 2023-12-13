using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject enemyPrefab;
    //public List<Transform> spawPoints;
    public Vector3 spawReferencePosition;
    public Quaternion spawRotation;
    
    //cantidad de instancias de enemigos
    public int amountToSpaw;
    //cadencia de instancia de enemigos
    public float spawCadence;
    //espera de tiempo al iniciar 
    public float initialWaitTime;


    private void Start()
    {
        StartCoroutine(EnemySpawnerCoroutine());
    }

    private IEnumerator EnemySpawnerCoroutine()
    {
        yield return new WaitForSeconds(initialWaitTime);

        for (int i = 0; i < amountToSpaw; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-spawReferencePosition.x, spawReferencePosition.x),
                                                                spawReferencePosition.y, spawReferencePosition.z);
            SpawEnemy(randomPosition, spawRotation);
        }
        yield return new WaitForSeconds(spawCadence);
    }

    public void SpawEnemy(Vector3 enemyPosition, Quaternion rotation)
    {
        Instantiate(enemyPrefab, enemyPosition, rotation);
    }
}
