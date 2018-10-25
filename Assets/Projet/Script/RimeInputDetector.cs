using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimeInputDetector : MonoBehaviour {

	public CustomCharacterController ccc;

	void Update () {
		/*if (Input.GetButton(InputName.JUMP))
		{
			Debug.Log(Input.GetAxis(InputName.JUMP));
		}*/
	}

	public static Vector3 HorizontalMoves()
	{
		Vector3 vector = Vector3.zero;
		if (Input.GetButton(InputName.HORIZONTAL))
		{
			vector = new Vector3(Input.GetAxis(InputName.HORIZONTAL),0,0);
		}
		return vector;
	}

	public static Vector3 VerticalMoves()
	{
		Vector3 vector = Vector3.zero;
		if (Input.GetButton(InputName.VERTICAL))
		{
			vector = new Vector3(0,0,Input.GetAxis(InputName.VERTICAL));
		}
		return vector;
	}
}
