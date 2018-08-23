using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveInimiga : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movimentacao();
	}
	void Movimentacao()
	{
		transform.Translate(0, -1 * speed * Time.deltaTime, 0);
	}
}
