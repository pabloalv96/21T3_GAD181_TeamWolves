﻿// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine.EventSystems;

#if UNITY_5_6_OR_NEWER   
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sends event when OnMoveEvent is called on the GameObject." +
		"\n Use GetLastPointerDataInfo action to get info from the event")]
	public class UiOnMoveEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when OnMoveEvent is called")]
		public FsmEvent onMoveEvent;

	    public override void Reset()
	    {
	        base.Reset();
	        onMoveEvent = null;
	    }
		
	    public override void OnEnter()
	    {
	        Init(EventTriggerType.Move, OnMoveDelegate);
	    }

	    private void OnMoveDelegate( BaseEventData data)
		{
			UiGetLastPointerDataInfo.lastPointerEventData = (PointerEventData) data;
			SendEvent(eventTarget, onMoveEvent);
		}
	}
}

#endif