using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserVerde : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(0,speed*Time.deltaTime,0);

		if (transform.position.y > 5.5f)
		{
			Destroy(this.gameObject);
		}
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		print("Enter");
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		print("Stay");
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		print("Exit");
	}
}
