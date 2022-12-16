using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldGuy : MonoBehaviour
{
    public GameObject block;
    public GameObject wall;
    public int ObjectCount = 0;
    public TMPro.TextMeshProUGUI blkCounter;


    float currentTime = 0f;
    float startingTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        blkCounter.text = (5-ObjectCount).ToString();
        currentTime -= 1 * Time.deltaTime;
        //print(currentTime);
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(ObjectCount < 5) {
                Instantiate(block, transform.position + new Vector3(0, -1 ,0), Quaternion.identity);
                ObjectCount++;

            }

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            Instantiate(wall, transform.position + new Vector3(3, 0 ,0), Quaternion.identity);
        }
    }
}

