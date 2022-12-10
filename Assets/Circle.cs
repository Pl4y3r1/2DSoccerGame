using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
	public bool collided;
	Vector2 vector;
	Vector2 vector2;

	void OnCollisionEnter2D(){
		collided = true;
		if(vector == Vector2.right){
			vector = Vector2.left;
		} else {
			vector = Vector2.right;
		}
	}


    // Start is called before the first frame update
    void Start()
    {
	vector = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
	OnCollisionEnter2D();

	if(collided){
		if(vector == Vector2.right){
			vector = Vector2.left;
			collided = false;
		} else {
			vector = Vector2.right;
			collided = false;
		}

	}
        transform.Translate(vector * 4 * Time.deltaTime);

    }
}
