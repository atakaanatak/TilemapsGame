using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject rewardPrefab;

    public float spawnTime = 1.0f;
    private float screenWidth = 8f;

    void Start()
    {
        InvokeRepeating("CreateObject", 1f, spawnTime);
    }

    void CreateObject()
    {
        float randomX = Random.Range(-screenWidth, screenWidth);
        Vector2 spawnPosition = new Vector2(randomX, 6f);

        GameObject selectedObjects;
        if (Random.value > 0.2f)
            selectedObjects = enemyPrefab;
        else
            selectedObjects = rewardPrefab;

        Instantiate(selectedObjects, spawnPosition, Quaternion.identity);
    }
}