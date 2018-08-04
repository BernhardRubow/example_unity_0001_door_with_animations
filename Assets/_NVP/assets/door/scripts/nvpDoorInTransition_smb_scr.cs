using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nvpDoorInTransition_smb_scr : nvpDoorStateBehaviour_scr {

	private float timer;
	private float threshold = 0.25f;
	bool warn = true;

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {
		nvpDoorStateBehaviour_scr.STATE = "transition";
  }

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		//if(nvpDoorStateBehaviour_scr.STATE != "transition") return;
		timer += Time.deltaTime;

		if(timer > threshold){

			if(warn){
				doorStateIndicatorRenderer.material.SetColor("_Color", Color.red);
			}
			else {
				doorStateIndicatorRenderer.material.SetColor("_Color", Color.white);
			}

			timer = 0f;
			warn = !warn;
		}
	}

	// // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		Debug.Log("Exit transition");
	}

}
