using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRacerData : MonoBehaviour {

  public Rigidbody rb;
  //float speed = 0.0f;
  //float rotationalSpeed = 0.0f;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("speed: " + rb.velocity.magnitude);
		Debug.Log("Angle: " + transform.eulerAngles.y   );
		 
	}
}
