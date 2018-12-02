using UnityEngine;

namespace Components.Traps {
	public class Hammer : AbstractTrap {
		#region Private fields
		[SerializeField] private float speed = 1;
		
		private Animator animator;
		#endregion

		#region Protected fields
		protected new readonly string animationName = "Hammer";
		#endregion

		#region Life cycle
		private void Awake() {
			animator = GetComponent<Animator>();
			animator.speed = speed;
		}
				#endregion
		
		#region Trap methods
		public override void Disable() {
			active = false;
			animator.Play("Idle");
		}
		#endregion
	}
}