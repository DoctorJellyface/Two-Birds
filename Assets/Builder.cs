
using UnityEngine;
using System.Collections;

public class Builder : MonoBehaviour {

	public GameObject cube;
	
	public GameObject birds;

	public float birdsPosition;
	public float addToPos;

	public float minX;
	public float maxX;

	public float minY;
	public float maxY;

	public float x;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		birdsPosition = birds.transform.position.x;
		
		if (birdsPosition + addToPos > x) {
			
			float randomX = Random.Range (minX, maxX);
			float randomY = Random.Range (minY, maxY);

			GameObject cube2 = Instantiate (cube, new Vector3 (x + (randomX / 2f), randomY / 2f,0f), Quaternion.identity) as GameObject;
			cube2.transform.localScale = new Vector3 (randomX, randomY,0);

			x += randomX;
	
		}
	}
}
