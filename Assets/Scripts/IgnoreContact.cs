using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreContact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RayCasting()
    {
        Physics2D.IgnoreLayerCollision(8, 10);
    }
}
