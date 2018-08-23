using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveController : MonoBehaviour {

	public float speed;
	public GameObject prefabLaser;
	public GameObject prefabLaserVerde;

	void Start () {
		
	}
	
	
	void Update () {

		Movimentacao();
		Atirar();
		AtirarVerde();
		VerificarLimites();
	}

	void Movimentacao()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		transform.Translate(h * speed * Time.deltaTime, 0, 0);
		transform.Translate(0, v * speed * Time.deltaTime, 0);
	}

	void Atirar()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(prefabLaser, transform.position + new Vector3(0, 0.67f, 0), Quaternion.identity);
		}
	}

	void AtirarVerde()
	{
		if (Input.GetMouseButtonDown(1))
		{
			Instantiate(prefabLaserVerde, transform.position + new Vector3(0, 0.67f, 0), Quaternion.identity);
		}
	}

	void VerificarLimites()
	{
		// Lateral
		if(transform.position.x > 8.2f){
			transform.position = new Vector3(8.2f, transform.position.y, 0);
		} else if (transform.position.x < -8.2f){
			transform.position = new Vector3(-8.2f, transform.position.y, 0);
		}
		// Vertical
		if (transform.position.y > 4.49f){
			transform.position = new Vector3(transform.position.x, 4.49f, 0);
		} else if (transform.position.y < -4.49f){
			transform.position = new Vector3(transform.position.x, -4.49f, 0);
		}
	}
}
