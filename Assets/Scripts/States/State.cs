using UnityEngine;
using System.Collections;

public class State : MonoBehaviour {
	public virtual void OnEnter() { Debug.Log("Entered " + name + " state."); }
	public virtual void OnLeave() { Debug.Log("Left " + name + " state."); }
	public virtual void OnUpdate() { Debug.Log("Updated " + name + " state."); }
}
