﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nvpDoorOpened_smb_scr : nvpDoorStateBehaviour_scr
{
  override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {
    doorStateIndicatorRenderer.material.SetColor("_Color", Color.green);
  }
}
