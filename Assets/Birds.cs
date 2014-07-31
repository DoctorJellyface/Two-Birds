using UnityEngine;
using System.Collections;

public class Birds : MonoBehaviour {

	public float speed;
	public float jumpHeight;

	void Update () {
		
		rigidbody2D.AddForce (new Vector2 (speed,0));
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			Vector2 temp = rigidbody2D.velocity;
			temp.y = jumpHeight;
			rigidbody2D.velocity = temp;
		
		//	rigidbody2D.AddForce (Vector2.up * jumpHeight, ForceMode2D.VelocityChange);
		}
	
	}
}
