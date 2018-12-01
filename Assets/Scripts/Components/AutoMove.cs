using UnityEngine;

namespace Components {
	[RequireComponent(typeof(GroundChecker))]
	public class AutoMove : MonoBehaviour {
		#region Properties
		public float Speed {
			get { return speed; }
			set { speed = value; }
		}
		
		#endregion
		
		#region Private fields
		[SerializeField] private float speed = 2f;

		private Rigidbody2D body;
		private GroundChecker groundChecker;
		#endregion

		#region Life cycle
		private void Awake() {
			body = GetComponent<Rigidbody2D>();
			groundChecker = GetComponent<GroundChecker>();
		}
	
		private void FixedUpdate() {
			if (!groundChecker.Grounded) return;

			var velocity = body.velocity;
			velocity.x = speed;
			body.velocity = velocity;
		}
		#endregion
	}
}
