using UnityEngine;
using System.Collections;

public class DieOnCollision : MonoBehaviour
{
	public LevelControllerExample controller;

	void OnCollisionEnter( Collision coll )
	{
		Debug.Log( "Block died!" );
		GameObject.Destroy( gameObject );
		controller.onBlockCollision( coll );
	}
}