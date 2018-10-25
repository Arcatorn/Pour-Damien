using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCharacterController : MonoBehaviour {

// Transform camPos = Camera.main.transform;
	Vector3 lastMoveDirection;
	private CharacterController controller;
	public float speed = 5;
	Transform mainCamera;
	public Camera cam;
	public static bool onGround = false;
	void Awake()
	{
		controller = GetComponent<CharacterController>();
	}
	void Start()
	{
		mainCamera = cam.transform;
	}
	
	public void Move(Vector3 direction)
	{
		var cameraAngle = mainCamera.rotation;
		mainCamera.eulerAngles = new Vector3(0, mainCamera.eulerAngles.y,0);
		direction = mainCamera.TransformDirection(direction);
		mainCamera.rotation = cameraAngle;
		this.controller.Move (direction * Time.deltaTime *speed);
		this.lastMoveDirection = direction;
	}

	public void Rotation(Vector3 direction)
	{
		
	}

	void Update()
	{
		Debug.DrawRay(this.transform.position, this.lastMoveDirection * 2, Color.red);
		GravityDetection();
	}

	void GravityDetection()
	{
		RaycastHit hitInfo;
		if (Physics.SphereCast(transform.position, 1, Vector3.down, out hitInfo, 0.25f, 1001))
		{
			onGround = true;
			CharacterControllerManager.chute = Vector3.zero;
		}
		else
		{
			onGround = false;
		}
	}
}
