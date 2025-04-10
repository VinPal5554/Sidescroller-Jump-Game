using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    private Player player;
    private float leftBound = -15.0f;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        
    }

    void Update()
    {
        if (!player.isDead)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
        
    }
}
