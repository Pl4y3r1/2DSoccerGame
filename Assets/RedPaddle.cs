using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPaddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)){
		transform.Translate(0,0.5f,0);
	} else if(Input.GetKeyDown(KeyCode.K)){
		transform.Translate(0,-0.5f,0);
	} else if(Input.GetKeyDown(KeyCode.J)){
		transform.Translate(-0.5f,0,0);
	} else if(Input.GetKeyDown(KeyCode.L)){
		transform.Translate(0.5f,0,0);
	}
    }
}
