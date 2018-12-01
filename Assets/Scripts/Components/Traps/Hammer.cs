using UnityEngine;

namespace Components.Traps {
	public class Hammer : AbstractTrap {
		#region Private fields
		private Animator animator;
		#endregion

		#region Protected fields
		protected new readonly string animationName = "Hammer";
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