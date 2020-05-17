﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{

    public float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject echo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            GameObject instance = Instantiate(echo, transform.position, Quaternion.identity);
            Destroy(instance, 2f);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
