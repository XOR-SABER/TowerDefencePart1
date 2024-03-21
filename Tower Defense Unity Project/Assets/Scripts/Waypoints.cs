using UnityEngine;

public class Waypoints : MonoBehaviour {

	public static Transform[] points;

	void Awake ()
	{
		// Arraylist? Actually nah. I'll win.
		points = new Transform[transform.childCount];
		for (int i = 0; i < points.Length; i++) {
			points[i] = transform.GetChild(i);
		}
	}

}
