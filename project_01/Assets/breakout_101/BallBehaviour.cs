﻿using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	public LevelController controller;

	void OnCollisionEnter( Collision col )
	{
		controller.onBallCollision( col );
	}
}

//public interface LevelControllerInterface
//{
//	void onBallCollision( Collision collision );
//}