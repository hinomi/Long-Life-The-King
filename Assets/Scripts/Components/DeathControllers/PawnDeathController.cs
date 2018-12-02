using Components.Traps;
using UnityEngine;

namespace Components.DeathControllers {
	public class PawnDeathController : AbstractDeathController {
		#region Properties
		public Transform Spawner {
			get { return spawner; }
			set { spawner = value; }
		}
		#endregion
		
		#region Private fields
		[SerializeField] protected LevelEnd levelEnd;
		[SerializeField] private Transform spawner;
		#endregion
		
		#region Death Controller methods
		public override void KilledBy(AbstractTrap trap) {
			trap.Disable();
			transform.position = spawner.transform.position;
			levelEnd.IncrementDeathCount();
		}
		#endregion
	}
}