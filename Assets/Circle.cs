using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
	private long count;
	private int REFLECT_CONSTANT = 2;
	private int NORMALIZE_CONSTANT = 3;
	Vector2 vector;

	void OnCollisionEnter2D(){
		if(vector == Vector2.right) {
            if(count%REFLECT_CONSTANT == 0){
                vector = Vector2.left + Vector2.up;
            } else if(count%NORMALIZE_CONSTANT == 0){
            	vector = Vector2.left;
            } else {
            	vector = Vector2.left + Vector2.down;
            }
            } else if(vector == Vector2.left) {
                if(count%REFLECT_CONSTANT == 0){
                    vector = Vector2.right + Vector2.down;
            	} else if(count%NORMALIZE_CONSTANT == 0){
                    vector = Vector2.right;
                } else {
                    vector = Vector2.right + Vector2.up;
                }
            } else if((vector - Vector2.down) == Vector2.left) {
                if(count%REFLECT_CONSTANT == 0){
                    vector = Vector2.right + Vector2.down;
            	} else if(count%NORMALIZE_CONSTANT == 0){
            	    vector = Vector2.right;
                } else{
            	    vector = Vector2.right + Vector2.up;
                }
            } else if((vector - Vector2.down) == Vector2.right) {
                if(count%REFLECT_CONSTANT == 0){
            		vector = Vector2.left + Vector2.down;
                } else if(count%NORMALIZE_CONSTANT == 0){
            		vector = Vector2.left;
                } else{
            		vector = Vector2.left + Vector2.up;
            	}
            } else if((vector - Vector2.up) == Vector2.right) {
                if(count%REFLECT_CONSTANT == 0){
            		vector = Vector2.left + Vector2.up;
            	} else if(count%NORMALIZE_CONSTANT == 0){
            		vector = Vector2.left;
            	} else {
            		 vector = Vector2.left + Vector2.down;
            	}
            } else if((vector - Vector2.up) == Vector2.left) {
            	if(count%REFLECT_CONSTANT == 0){
            		vector = Vector2.right + Vector2.down;
            	} else if(count%NORMALIZE_CONSTANT == 0){
            		vector = Vector2.right;
                } else {
            		vector = Vector2.right + Vector2.down;
                }
           }
		count++;
	}

    // Start is called before the first frame update
    void Start()
    {
	    vector = Vector2.right;
	    count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vector * 4 * Time.deltaTime);
    }
}
