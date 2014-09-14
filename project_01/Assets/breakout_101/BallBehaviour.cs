using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	public LevelControllerExample controller;

	void OnCollisionEnter( Collision col )
	{
		controller.onBallCollision( col );
	}
}