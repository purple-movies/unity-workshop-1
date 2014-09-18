using UnityEngine;
using System.Collections;

public class MazeNode : MonoBehaviour
{
	public enum DIRECTION {NONE, NORTH, EAST, SOUTH, WEST};

	public DIRECTION[] possibleDirections = new DIRECTION[2];

	void Awake()
	{
		possibleDirections[0] = DIRECTION.NORTH;
		possibleDirections[1] = DIRECTION.SOUTH;
	}

	void Start ()
	{
		
	}
//	
//	void Update ()
//	{
//	
//	}
}