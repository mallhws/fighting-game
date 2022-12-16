using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{



    void Start()
    {
        Invoke("destroy", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void destroy()
    {
        Destroy(gameObject);
    }
}
