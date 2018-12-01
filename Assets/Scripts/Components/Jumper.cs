using UnityEngine;

namespace Components {
	public class Jumper : MonoBehaviour {
		#region Private fields
		[SerializeField] private string targetTag = "King";
		[SerializeField] private float force = 1f;
		#endregion
		
		#region Life cycle
		private void OnTriggerEnter2D(Collider2D coll) {
			if (!coll.CompareTag(targetTag)) return;

			var body = coll.GetComponent<Rigidbody2D>();
			body.AddForce(Vector2.up * force, ForceMode2D.Impulse);
		}
		#endregion
	}
}
