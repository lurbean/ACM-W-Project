using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed;
	public float rotationSpeed;
	private CharacterController cc;

	void Start()
	{
		cc = GetComponent<CharacterController>();
	}

	void Update()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
		
		Vector3 moveDirectionForward = transform.forward * verticalInput;

		transform.Rotate(0, horizontalInput * rotationSpeed, 0);

		Vector3 direction = (moveDirectionForward).normalized;
		Vector3 distance = direction * speed * Time.deltaTime;


		cc.Move(distance);

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