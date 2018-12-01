using UnityEngine;

namespace Components.DeathControllers {
	public class KingDeathController : AbstractDeathController {
		#region Private fields
		[SerializeField] private GameObject deathPanel;
		private Animator animator;
		#endregion

		#region Life cycle
		private void Awake() {
			animator = GetComponent<Animator>();
		}
		#endregion
		
		#region Death Controller methods
		public override void KilledBy(AbstractTrap trap) {
			var autoMove = GetComponent<AutoMove>();
			autoMove.enabled = false;
			animator.Play("Death");
		}
		#endregion

		#region Public methods
		public void Dead() {
			enabled = false;
			Time.timeScale = 0;
			deathPanel.SetActive(true);
		}
		#endregion
	}
}