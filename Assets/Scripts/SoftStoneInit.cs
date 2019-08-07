using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftStoneInit : MonoBehaviour
{
    public GameObject prefab;

    public GameObject obj;
    
    void Awake()
    {
        int seed = Environment.TickCount;
        System.Random r = new System.Random();
        for (int x = -24;x < 28;x+=4) 
        {
            for (int z =-24; z < 28; z+=4) 
            {
                if (ShouldSet(r))
                {
                    GameObject g = Instantiate(prefab, obj.transform);
                    g.transform.position = new Vector3(x, 0, z);
                }
            }

        }
    }

    bool ShouldSet(System.Random r)
    {
        return r.Next(1000) > 666;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
