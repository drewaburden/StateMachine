using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {
	private static T instance = null;
	public static T Instance {
		get {
			if (instance == null) {
				instance = (T) FindObjectOfType<T>();
				
				if (instance == null) {
					GameObject singleton = new GameObject();
					instance = singleton.AddComponent<T>();
					DontDestroyOnLoad(singleton);
				}
			}

			return instance;
		}
	}
}