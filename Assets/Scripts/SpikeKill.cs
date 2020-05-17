using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeKill : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    public int scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(scene);
            col.transform.position = spawnPoint.position;
        }
    }
}
