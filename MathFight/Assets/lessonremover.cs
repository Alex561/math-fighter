using UnityEngine;
using System.Collections;

public class lessonremover : MonoBehaviour {
	//public string[] dialogue={"Math Lessons","This is a test"};
	//int index=0;
	//Rect dialoguerect=new Rect(435,100,500,50);
	public bool flip=false;
	public string name;
	public int count=0;
	Vector3 bleh=new Vector3(5.47f,-1.52f,-27.06f);
	// Use this for initialization
	void Start () {

	}
	void OnGUI()
	{
		name = GUI.TextField (new Rect (10, 10, 200, 200), name, 25);
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space"))
			{

			Debug.Log ("return");
			flip=true;
			Debug.Log ("what the fucks going on");
			GetComponent<TextMesh>().text = "what is the angle for tan 45?";
			Debug.Log("the fucks wrong with you");
			count++;
			if(count==1)
			{
				if(Input.GetKeyDown("space"))
				   {
					GetComponent<TextMesh>().text = "what is the angle for cos 60?";
					}
			}
			//GetComponent<Collider>().attachedRigidbody.useGravity = true;
			//GetComponent<Collider>().attachedRigidbody.isKinematic = false;


		}

		if (Input.GetKeyDown (KeyCode.G)) {
			if (name == "1") { 
				flip = false;
				GetComponent<Collider> ().attachedRigidbody.position = bleh;
				GetComponent<Collider> ().attachedRigidbody.isKinematic = true;
				GetComponent<TextMesh> ().text = "correct";
			}
			else {
				GetComponent<TextMesh> ().text = "wrong bitch!";
	
			}
		}
}
}