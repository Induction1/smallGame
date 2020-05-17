using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    [SerializeField] Transform ballSpawn;
    public GameObject basketball;
    private Rigidbody2D rb;

    void Start()
	{
        rb = GetComponent<Rigidbody2D>();
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Enemy"))
        {
            col.transform.position = ballSpawn.position;
            basketball.transform.position = ballSpawn.position;
        }
    }
}
