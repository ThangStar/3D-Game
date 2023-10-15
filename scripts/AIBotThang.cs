using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBotThang : MonoBehaviour
{
    // Start is called before the first frame update
    Transform player;
    public float rotationSpeed = 2.0f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        // Rotate the enemy to face the character
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            Quaternion.LookRotation(direction),
            rotationSpeed * Time.deltaTime
        );
    }
}
