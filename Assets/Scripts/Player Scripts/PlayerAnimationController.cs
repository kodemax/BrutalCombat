using UnityEngine;
using System.Collections;

public class PlayerAnimationController : MonoBehaviour {
	
	private Animator anim;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
		anim.SetLayerWeight(1, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
