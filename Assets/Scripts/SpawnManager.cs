using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefaps;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spawning random dog by keydown "S"
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Randomly genegate animalindex and spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefaps.Length);
            Instantiate(animalPrefaps[animalIndex], spawnPos, animalPrefaps[animalIndex].transform.rotation);
        }
    }
}
