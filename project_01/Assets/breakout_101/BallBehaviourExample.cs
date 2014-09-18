using UnityEngine;
using System.Collections;

public class BallBehaviourExample : MonoBehaviour {

	public LevelControllerExample controller;

	void OnCollisionEnter( Collision col )
	{
		controller.onBallCollision( col );
	}
}

//public interface LevelControllerInterface
//{
//	void onBallCollision( Collision collision );
//}