using UnityEngine;

namespace Components {
	public abstract class AbstractDeathController : MonoBehaviour {
		#region Abstract methods
		public abstract void KilledBy(Trap trap);
		#endregion
	}
}