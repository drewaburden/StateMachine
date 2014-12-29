using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StateMachine : Singleton<StateMachine> {
	public List<State> states = new List<State>();
	public State currentState = null;

	protected StateMachine() {} // prevent constructor access

	void Awake() {
		states.AddRange(GetComponentsInChildren<State>());
	}
	void Update() {
		if (currentState != null) currentState.OnUpdate();
	}

	public void AddState(State state) {
		states.Add(state);
	}
	public void ChangeState(string name) { ChangeState(states.Find(searchItem => searchItem.name == name)); }
	public void ChangeState(State state) {
		if (currentState != null) currentState.OnLeave();
		currentState = states.Find(searchItem => searchItem == state);
		if (currentState == null) Debug.LogWarning("Tried to change state to a null or non-existent state.");
		else currentState.OnEnter();
	}
}
