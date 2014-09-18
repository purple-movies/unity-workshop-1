using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour
{
	MazeNode.DIRECTION currentDirection = MazeNode.DIRECTION.NONE;
	Vector3 curDirectionVec = Vector3.zero;

	void Update ()
	{
		if( Input.GetKey(KeyCode.W) ){
			currentDirection = MazeNode.DIRECTION.NORTH;
		}
		if( Input.GetKey(KeyCode.D) )
		{
			currentDirection = MazeNode.DIRECTION.EAST;
		}
		if( Input.GetKey(KeyCode.S) )
		{
			currentDirection = MazeNode.DIRECTION.SOUTH;
		}
		if( Input.GetKey(KeyCode.A) )
		{
			currentDirection = MazeNode.DIRECTION.WEST;
		}
		switch( currentDirection ) {
		case MazeNode.DIRECTION.NORTH: curDirectionVec.z = .01f; break;
		case MazeNode.DIRECTION.SOUTH: curDirectionVec.z =-.01f; break;
		case MazeNode.DIRECTION.EAST: curDirectionVec.x = .01f; break;
		case MazeNode.DIRECTION.WEST: curDirectionVec.x =-.01f; break;
		}
	}

	void FixedUpdate ()
	{
		Debug.Log( "dir : " + curDirectionVec );

		transform.Translate(curDirectionVec);
//		transform.Translate(Time.deltaTime, 0, 0 );
	}
}
