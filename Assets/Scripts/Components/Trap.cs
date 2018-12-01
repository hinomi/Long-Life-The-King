using UnityEngine;

namespace Components {
	public class Trap : MonoBehaviour {
		#region Life cycle
		private void OnTriggerEnter2D(Collider2D coll) {
			var deathController = coll.GetComponent<AbstractDeathController>();
			if (deathController != null) deathController.KilledBy(this);
		}
		#endregion
	}
}