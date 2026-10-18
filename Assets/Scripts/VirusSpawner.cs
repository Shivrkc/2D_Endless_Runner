using UnityEngine;

public class VirusSpawner : MonoBehaviour
{
    public GameObject virusPrefab;
    public float spawnInterval = 2f;
    public float spawnYMin = -3.5f;
    public float spawnYMax = 3.5f;
    public float spawnX = 8f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnVirus), 1f, spawnInterval);
    }

    void SpawnVirus()
    {
        if (PlayerController.gameOver)
        {
            CancelInvoke(nameof(SpawnVirus));
            return;
        }

        if (virusPrefab == null)
        {
            Debug.LogError("Virus Prefab is not assigned!");
            return;
        }

        float randomY = Random.Range(spawnYMin, spawnYMax);

        Vector3 spawnPosition = new Vector3(
            spawnX,
            randomY,
            0f
        );

        Instantiate(
            virusPrefab,
            spawnPosition,
            Quaternion.identity
        );
    }
}