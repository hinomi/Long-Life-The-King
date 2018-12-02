using UnityEngine;
using UnityEngine.UI;

namespace Components.UI {
	public class Star : MonoBehaviour {
		#region Private fields
		[SerializeField] private Sprite filledStar;
		[SerializeField] private Image image;
		#endregion

		#region Public methods
		public void Fill() {
			image.sprite = filledStar;
		}
		#endregion
	}
}