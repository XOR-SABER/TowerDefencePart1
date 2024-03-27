using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;
	public GameObject standardTurretPrefab;

	void Awake ()
	{
		instance = this;
	}

	void Start ()
	{
		turretToBuild = standardTurretPrefab;
	}

	private GameObject turretToBuild;

	public GameObject GetTurretToBuild ()
	{
		return turretToBuild;
	}

}
