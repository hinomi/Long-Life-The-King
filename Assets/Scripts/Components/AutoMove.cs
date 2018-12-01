using UnityEngine;

namespace Components {
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
		#endregion

		#region Life cycle
		private void Awake() {
			body = GetComponent<Rigidbody2D>();
		}
	
		private void FixedUpdate() {
			var velocity = body.velocity;
			velocity.x = speed;
			body.velocity = velocity;
		}
		#endregion
	}
}
