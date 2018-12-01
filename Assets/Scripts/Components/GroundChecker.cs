using UnityEngine;

namespace Components {
	public class GroundChecker : MonoBehaviour {
		#region Properties
		public bool Grounded {
			get { return grounded; }
		}
		#endregion
		
		#region Private fields
		[SerializeField] private LayerMask groundLayer;
		
		private float distToGround;
		private bool grounded;
		#endregion
		
		#region Life cycle
		private void Awake() {
			var coll = GetComponent<Collider2D>();
			distToGround = coll.bounds.extents.y;
		}
		
		private void OnCollisionEnter2D(Collision2D collision) {
			UpdateGrounded();
		}

		private void OnCollisionExit2D(Collision2D collision) {
			UpdateGrounded();
		}
		#endregion

		#region Private methods
		private void UpdateGrounded() {
			grounded = Physics2D.Raycast(transform.position, Vector3.down, distToGround + 0.1f, groundLayer);
		}
		#endregion
	}
}
