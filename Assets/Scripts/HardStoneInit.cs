using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardStoneInit : MonoBehaviour
{
    public GameObject prefab;

    public GameObject obj;
    
    void Awake()
    {
        for (int x = -26; x <= 28; x+=4)
        {
            for (int z = -26; z<=28;z+=4) 
            {
                GameObject g = Instantiate(prefab, obj.transform);
                g.transform.position = new Vector3(x, 0, z);   
            }
        }
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
