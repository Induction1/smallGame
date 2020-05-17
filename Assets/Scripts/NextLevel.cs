using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public int scene;
    private void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(scene + 1);
        }
    }
}
