using UnityEngine;
using UnityEditor;

/// <summary>
/// Draws the attack radius of Attacker in editor (assuming y is up in world space)
/// </summary>
[CustomEditor( typeof( UnitAttacker2D ) )]
public class UnitAttacker2DEditor : Editor
{
	void OnSceneGUI( )
	{
		var t = (UnitAttacker2D)target;
		var mesh = t.GetComponent<MeshRenderer>();

		var pos = t.transform.position;

		if (mesh != null) {
			pos.z = mesh.bounds.max.z;
		} else {
			pos.z = t.transform.position.z;
		}
		pos.z -= 0.01f; 	// add a small epsilon to prevent z-fighting


		Handles.color = Color.red;
		Handles.DrawWireDisc(pos, Vector3.back, t.attackRadius);
	}
}