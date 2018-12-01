using Components.DeathControllers;
using UnityEngine;

namespace Components {
	public abstract class AbstractTrap : MonoBehaviour {
		#region Life cycle
		private void OnTriggerEnter2D(Collider2D coll) {
			var deathController = coll.GetComponent<AbstractDeathController>();
			if (deathController != null) deathController.KilledBy(this);
		}
		#endregion

		#region Abstract methods
		public abstract void Disable();
		#endregion
	}
}