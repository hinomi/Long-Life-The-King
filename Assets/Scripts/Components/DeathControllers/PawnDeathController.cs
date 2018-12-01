namespace Components.DeathControllers {
	public class PawnDeathController : AbstractDeathController {
		#region Death Controller methods
		public override void KilledBy(AbstractTrap trap) {
			trap.Disable();
			Destroy(gameObject);
		}
		#endregion
	}
}