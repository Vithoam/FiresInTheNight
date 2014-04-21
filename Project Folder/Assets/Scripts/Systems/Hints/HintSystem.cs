using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HintSystem : MonoBehaviour 
{
	public List<Hint> Queue = new List<Hint>();

	public static HintSystem Instance;

	public void Start() { HintSystem.Instance = this; }

	public static void QueueHint(Hint hint)	{	HintSystem.Instance.Queue.Add(hint);	}
	public static void RemoveHint(Hint hint) { 	HintSystem.Instance.Queue.Remove(hint); }

	public static void ClearAll() { HintSystem.Instance.Queue.Clear(); }

	public void OnGUI()
	{
		if(Queue[0] == null)
			return;


	}

}


[System.Serializable]
public class Hint
{
	public string Text;
	public float duration = 3f;
}