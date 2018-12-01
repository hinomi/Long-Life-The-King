using UnityEngine;
using UnityEngine.SceneManagement;

namespace Components {
	public class SceneReloader : MonoBehaviour {
		#region Public methods
		public void Reload() {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		#endregion
	}
}