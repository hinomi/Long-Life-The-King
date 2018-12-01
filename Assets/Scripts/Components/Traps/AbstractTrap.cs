using Components.DeathControllers;
using UnityEngine;

namespace Components.Traps {
	public abstract class AbstractTrap : MonoBehaviour {
		#region Properties
		public string AnimationName {
			get { return animationName; }
		}
		#endregion
		
		#region Protected fields
		protected string animationName;
		#endregion
		
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