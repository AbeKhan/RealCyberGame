using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlay : MonoBehaviour
{
    public float speed = 5.0f; // The speed at which the enemy moves towards the player
    private Transform player; // The player's transform

    void Start()
    {
        // Find the player's transform
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        // Move the enemy towards the player
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}

