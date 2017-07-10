using UnityEngine;
using System.Collections;

namespace Strategies {
	/// <summary>
	/// Just move around randomly
	/// </summary>
	[RequireComponent(typeof(Wander))]
	[RequireComponent(typeof(UnitAttacker2D))]
	public class WanderAndShoot : AIStrategy {
		void Start() {
			Reset ();
		}

		void Reset() {
			GetComponent<UnitAttacker2D> ().attackOnSight = true;
		}
	}
}