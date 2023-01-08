using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] entitiesPrefabs;
    [SerializeField] private Vector3 spawnPosition;
    [SerializeField] private float entitiesSpeed, xMargin, spawnTimer, spawnTimerMax;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        if(spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        else
        {
            spawnTimer = spawnTimerMax;
            SpawnEntity();
        }
    }

    private void SpawnEntity()
    {
        GameObject entityToSpawn = entitiesPrefabs[Random.Range(0, entitiesPrefabs.Length)];
        spawnPosition.x = Random.Range(-xMargin, xMargin);

        GameObject spawnedEntity = Instantiate(entityToSpawn, spawnPosition, Quaternion.identity);
        spawnedEntity.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -entitiesSpeed);
    }
}
