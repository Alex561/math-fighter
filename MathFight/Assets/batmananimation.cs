using UnityEngine;
using System.Collections;

public class batmananimation : MonoBehaviour {

	Animator anim;
	int punch=Animator.StringToHash("Punch");
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		AnimatorStateInfo stateinfo = anim.GetCurrentAnimatorStateInfo (0);
		if (Input.GetKeyDown (KeyCode.W)) {
			anim.SetBool("standing",false);
		}
		else
		   {
			anim.SetBool("standing",true);
		}
	}
}
