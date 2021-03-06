﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject {

	public float maxSpeed = 7;
	public float jumpTakeOffSpeed = 7;
	
	protected override void ComputeVelocity(){
		Vector2 move = Vector2.zero;
		move.x = Input.GetAxis("Horizontal");

		if(Input.GetKeyDown("w") && grounded){
			velocity.y = jumpTakeOffSpeed;
		}else if (Input.GetKeyUp("w"))
		{
			if (velocity.y > 0)
				velocity.y = velocity.y *.5f;
		}

		targetVelocity = move * maxSpeed;

	}
}

