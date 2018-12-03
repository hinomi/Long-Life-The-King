using Components.Traps;
using Gamekit2D;
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
		[SerializeField] private RandomAudioPlayer deathAudioPlayer;
		#endregion
		
		#region Death Controller methods
		public override void KilledBy(AbstractTrap trap) {
			trap.Disable();
			transform.position = spawner.transform.position;
			levelEnd.IncrementDeathCount();
			deathAudioPlayer.PlayRandomSound();
		}
		#endregion
	}
}