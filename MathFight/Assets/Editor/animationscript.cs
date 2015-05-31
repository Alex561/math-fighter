#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;

public class animationscript : EditorWindow {

	public GameObject target;
	public AnimationClip idleAnim;
	public AnimationClip punchAnim;
	public AnimationClip blockAnim;
	public AnimationClip gotpunchAnim;

	[MenuItem("Window/animationscript")]
	static void OpenWindow()
	{
		GetWindow<animationscript> ();
	}
	void OnGUI()
	{
		target = EditorGUILayout.ObjectField ("Target Object", target, typeof(GameObject), true)as GameObject;
		idleAnim = EditorGUILayout.ObjectField ("Idle", idleAnim, typeof(AnimationClip), false)as AnimationClip;
		punchAnim = EditorGUILayout.ObjectField ("punch", punchAnim, typeof(AnimationClip), false)as AnimationClip;
		blockAnim = EditorGUILayout.ObjectField ("block", blockAnim, typeof(AnimationClip), false)as AnimationClip;
		gotpunchAnim = EditorGUILayout.ObjectField ("gotpunched", gotpunchAnim, typeof(AnimationClip), false)as AnimationClip;

		if (GUILayout.Button ("Create")) 
		{
			if(target==null)
			{
				Debug.LogError("No target for animator controller set");
				return;
			}
			Create ();
		}
	}
	void Create()
	{
		AnimatorController controller = AnimatorController.CreateAnimatorControllerAtPath ("Assets/" + target.name + ".controller");
		controller.AddParameter ("Speed", AnimatorControllerParameterType.Float);
		AnimatorState idleState = controller.layers [0].stateMachine.AddState ("Idle");
		idleState.motion = idleAnim;

		BlendTree blendTree;
		AnimatorState moveState = controller.CreateBlendTreeInController ("punch", out blendTree);

		blendTree.blendType = BlendTreeType.Simple1D;
		blendTree.blendParameter = "Speed";
		blendTree.AddChild (punchAnim);
		blendTree.AddChild (blockAnim);

		AnimatorStateTransition leaveIdle = idleState.AddTransition (moveState);
		AnimatorStateTransition leaveMove = moveState.AddTransition (idleState);

		leaveIdle.AddCondition (AnimatorConditionMode.Greater, 0.01f, "Speed");
		leaveMove.AddCondition (AnimatorConditionMode.Less, 0.01f, "Speed");
		target.GetComponent<Animator> ().runtimeAnimatorController = controller;

	}
}		
#endif