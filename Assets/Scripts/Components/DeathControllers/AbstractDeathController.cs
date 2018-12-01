using UnityEngine;

namespace Components.DeathControllers {
	public abstract class AbstractDeathController : MonoBehaviour {
		#region Abstract methods
		public abstract void KilledBy(AbstractTrap trap);
		#endregion
	}
}