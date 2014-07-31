//
//  Builder.cs is part of Two Birds.
//
//  Author:
//       Juraj Fiala <doctorjellyface@riseup.net>
//
//  Copyright (c) 2014 Juraj Fiala
//
//  Two Birds is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Two Birds is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with Two Birds.  If not, see <http://www.gnu.org/licenses/>.
//
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
