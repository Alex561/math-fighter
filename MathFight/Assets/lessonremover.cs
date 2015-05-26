using UnityEngine;
using System.Collections;

public class lessonremover : MonoBehaviour {
	//public string[] dialogue={"Math Lessons","This is a test"};
	//int index=0;
	//Rect dialoguerect=new Rect(435,100,500,50);
	public bool flip=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
			{
			Debug.Log ("return");
			flip=true;
			Debug.Log ("what the fucks going on");
			GetComponent<Collider>().attachedRigidbody.useGravity = true;
			GetComponent<Collider>().attachedRigidbody.isKinematic = false;

		}
	
	}
	
	/*void OnGUI()
	{
		if (index < dialogue.Length) {
			GUI.Box (dialoguerect, dialogue [index]);
		}
		else{
		}
	}*/
}
