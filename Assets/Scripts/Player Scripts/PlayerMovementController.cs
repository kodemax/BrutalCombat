using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {
	
	private Animator anim;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float speed = Input.GetAxis("Vertical");
		float movementSpeed = anim.GetFloat("MovementSpeed");
		if(speed > 0)
			movementSpeed = Mathf.Lerp(movementSpeed, 1.0f, 0.1f);
		else if( speed < 0)
			movementSpeed = Mathf.Lerp(movementSpeed, -1.0f, 0.1f);
		else
			movementSpeed = Mathf.Lerp(movementSpeed, 0.0f, 0.1f);
		
		anim.SetFloat("MovementSpeed", movementSpeed);
	}
}
