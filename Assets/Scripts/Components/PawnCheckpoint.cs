using Components.DeathControllers;
using UnityEngine;

namespace Components {
	public class PawnCheckpoint : MonoBehaviour {
		#region Life cycle
		private void OnTriggerEnter2D(Collider2D coll) {
			var deathController = coll.GetComponent<PawnDeathController>();
			if (deathController != null) deathController.Spawner = transform;
		}
		#endregion
	}
}