using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaGuy : MonoBehaviour
{
    string direction = "right";
	public GameObject banana;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			direction = "right";
		}else if(Input.GetKeyDown(KeyCode.LeftArrow)){
			direction = "left";
			
		}
		Debug.Log(direction);
		
		
		if(Input.GetKeyDown(KeyCode.Keypad0))
		{
			Banana b = null;
			if(direction == "left")
			{
				 b = Instantiate(banana, transform.position+ new Vector3(-1,0,0), Quaternion.identity).GetComponent<Banana>();
			}else if(direction == "right")
			{
				b = Instantiate(banana, transform.position+ new Vector3(1,0,0), Quaternion.identity).GetComponent<Banana>();
			}
			
			b.launch(direction);
		}
    }
}
