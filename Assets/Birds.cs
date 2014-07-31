// 
// Two Birds - a little game inspired by (but not quite like) Flappy Bird
// Copyright (C) 2014 Juraj Fiala <doctorjellyface@riseup.net>
// 
// This file is part of Two Birds.
// 
//     Two Birds is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//
//     Two Birds is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with Two Birds.  If not, see <http://www.gnu.org/licenses/>.

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
