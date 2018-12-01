using UnityEngine;

namespace Components.DeathControllers {
	public class PawnDeathController : AbstractDeathController {
		#region Private fields
		[SerializeField] private Transform spawner;
		#endregion
		
		#region Death Controller methods
		public override void KilledBy(AbstractTrap trap) {
			trap.Disable();
			transform.position = spawner.transform.position;
		}
		#endregion
	}
}