using UnityEngine;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Vector3 positionOffset;

	private GameObject turret;

	private Renderer rend;
	private Color startColor;

	void Start () {
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
    }

	void OnMouseDown () {
		if (turret != null) {
			//TODO: 
			return;
		}

		GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
		turret = Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
	}

	void OnMouseEnter () {
		rend.material.color = hoverColor;
	}

	void OnMouseExit () {
		rend.material.color = startColor;
    }

}
