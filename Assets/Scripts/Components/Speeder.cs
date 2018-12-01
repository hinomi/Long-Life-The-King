using UnityEngine;

namespace Components {
	public class Speeder : MonoBehaviour {
		#region Private fields
		[SerializeField] private float speed;
		#endregion

		#region Life cycle
		private void OnTriggerEnter2D(Collider2D coll) {
			var autoMove = coll.GetComponent<AutoMove>();
			if (autoMove != null) autoMove.Speed = speed;
		}
		#endregion
	}
}
