using UnityEngine;
using System.Collections;

public class lessonremover : MonoBehaviour {
	//public string[] dialogue={"Math Lessons","This is a test"};
	//int index=0;
	//Rect dialoguerect=new Rect(435,100,500,50);
	public bool flip=false;
	public string name;
	public int input_count=0;
	public int output_count=0;
	Vector3 bleh=new Vector3(5.47f,-1.52f,-27.06f);
	// Use this for initialization
	void Start () {

	}
	//void OnGUI()
	//{
		//name = GUI.TextField (new Rect (10, 10, 200, 200), name, 25);
	//}
	// Update is called once per frame
	void OnCollisionEnter (Collision col)
	{
		if(input_count==0)
		{
			GetComponent<TextMesh>().text = "what is the angle for tan 45?";
		}
		
		if(input_count==1)
		{
			
			GetComponent<TextMesh>().text = "what is the angle for cos 60?";
		}
		//GetComponent<Collider>().attachedRigidbody.useGravity = true;
		//GetComponent<Collider>().attachedRigidbody.isKinematic = false;
		if(input_count==2)
		{
			GetComponent<TextMesh>().text = "what is the angle for sin 60?";
		}
		input_count++;

	}
	void Update () {
		if (input_count == 3) {
			Application.LoadLevel("Fight");
		}
//		if (Input.GetKeyDown("space"))
//			{
//			 
//			if(input_count==0)
//			{
//			GetComponent<TextMesh>().text = "what is the angle for tan 45?";
//			}
//
//			if(input_count==1)
//			{
//				   
//					GetComponent<TextMesh>().text = "what is the angle for cos 60?";
//			}
//			//GetComponent<Collider>().attachedRigidbody.useGravity = true;
//			//GetComponent<Collider>().attachedRigidbody.isKinematic = false;
//			if(input_count==2)
//			{
//				GetComponent<TextMesh>().text = "what is the angle for sin 60?";
//			}
//			input_count++;
	//	}

		if (Input.GetKeyDown (KeyCode.G)) {

			if (name == "1"&& output_count ==0) { 

				Debug.Log("ok");
				GetComponent<Collider> ().attachedRigidbody.position = bleh;
				GetComponent<Collider> ().attachedRigidbody.isKinematic = true;
				GetComponent<TextMesh> ().text = "correct";

			}
			else if((name=="1/2")&&(output_count==1))
			{
				GetComponent<TextMesh> ().text = "correct";
			}
			else if(name=="s3/2"&&output_count==2)
			{
				GetComponent<TextMesh> ().text = "correct";
			}
			else {

				GetComponent<TextMesh> ().text ="Unit circle \n Angle	Sin	   Cos	 Tan=Sin/Cos \n 30°	1/2	  √3/2	 1√3 =  √33 \n 45°	√2/2	√2/2	1 \n 60°	√3/2	  1/2	√3";
				input_count--;
				output_count--;
													
			}
			output_count++;
		}
}
}