using UnityEngine;

namespace Components.Traps {
	public class Hammer : AbstractTrap {
		#region Private fields
		private Animator animator;
		#endregion

		#region Life cycle
		private void Awake() {
			animator = GetComponent<Animator>();
		}
		#endregion
		
		#region Trap methods
		public override void Disable() {
			enabled = false;
			animator.Play("Idle");
		}
		#endregion
	}
}