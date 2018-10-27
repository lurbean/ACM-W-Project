using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed;
	public float y;
	private CharacterController cc;

	private Vector3 moveDirection = Vector3.zero;

	void Start()
	{
		cc = GetComponent<CharacterController>();
	}

	void Update()
	{

		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection = moveDirection * speed;

		moveDirection.y = y;

		cc.Move(moveDirection * Time.deltaTime);

	}

	void OnControllerColliderHit(ControllerColliderHit hit)
	{

		//print("Collisding with" + hit.collider.gameObject.name);

	}
	void OnCollisionEnter(Collision c)
	{

		//print("Player stopped colliding with" + c.collider.gameObject.name);


	}

}