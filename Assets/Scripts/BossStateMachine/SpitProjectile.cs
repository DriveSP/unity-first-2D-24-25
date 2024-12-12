using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitProjectile : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    [SerializeField] private float force;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();

        Vector2 direction = (Vector2)player.transform.position - (Vector2)transform.position;
        rb.AddForce(direction, ForceMode2D.Impulse);
    }

}
