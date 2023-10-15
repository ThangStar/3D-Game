using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowMe : MonoBehaviour
{
    public Transform targetObj;
     NavMeshAgent enemy;
    public Transform player;
    public float speed = 2.0f;
    public float rotationSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, speed * Time.deltaTime);
        //enemy.SetDestination(player.position);
        // Calculate the direction to the character
        Vector3 direction = player.position - transform.position;
        // Rotate the enemy to face the character
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            Quaternion.LookRotation(direction),
            rotationSpeed * Time.deltaTime
        );
    }
}
