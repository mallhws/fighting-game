using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public int ObjectCount;
    

    // Start is called before the first frame update
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
