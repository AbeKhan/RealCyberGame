using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab; // The enemy prefab to spawn
    public float spawnInterval = 5.0f; // The time interval between spawns

    private float timer = 0.0f; // A timer to control the spawn interval

    void Update()
    {
        timer += Time.deltaTime; // Increase the timer by the time since the last frame

        if (timer >= spawnInterval) // If the timer has reached the spawn interval
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity); // Spawn the enemy at the position of the game object this script is attached to
            timer = 0.0f; // Reset the timer
        }
    }
}
