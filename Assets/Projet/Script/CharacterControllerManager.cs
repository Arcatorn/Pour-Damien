using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerManager : MonoBehaviour {

	public CustomCharacterController ccc;	
	float gravityAcceleration = -9.81f;
	float maxVitesse = -20f;

	public static Vector3 chute = Vector3.zero;
	
	void Update () {
		Vector3 position = RimeInputDetector.HorizontalMoves() + RimeInputDetector.VerticalMoves();
		if (!CustomCharacterController.onGround)
		{
			if (chute.y > maxVitesse)
			{
				chute.y += gravityAcceleration * Time.deltaTime;
				position += chute;
			}
			else {
				position += chute;
			}
		}
		ccc.Move(position);
	}
}
