using UnityEngine;
using System.Collections;

public class LevelControllerExample : MonoBehaviour
{
	public GameObject ball;
	public GameObject paddle;
	public GameObject floor;
	public GameObject blocksContainer;

	float paddleSpeed = .35f;
	Vector3 ballStartPosition;
	bool levelCompleted;

	void Start ()
	{
		Debug.Log( "start" );

		levelCompleted = false;

		ballStartPosition = ball.transform.position;
		resetBall();
	}

	void resetBall ()
	{
		var startVelocity = new Vector3( 0, -10 );
		ball.GetComponent<Rigidbody> ().velocity = startVelocity;
		ball.transform.position = ballStartPosition;
	}

	public void onBlockCollision( Collision Collision )
	{
		if ( blocksContainer.transform.childCount <= 1 )
		{
			levelCompleted = true;
			Debug.Log( "level complete !!!" );
		}
	}

	public void onBallCollision( Collision collision )
	{
//		Debug.Log( "collision : " + collision.gameObject );

		if ( ! levelCompleted && collision.gameObject == floor )
		{
			resetBall ();
		}
	}

	void Update ()
	{
//		Debug.Log( "update" );
		var t = paddle.transform.position;

		if ( Input.GetKey(KeyCode.LeftArrow) )
		{
			t.x -= paddleSpeed;
			paddle.transform.position = t;
		}
		else if ( Input.GetKey(KeyCode.RightArrow) )
		{
			t.x += paddleSpeed;
			paddle.transform.position = t;
		}
	}
}
