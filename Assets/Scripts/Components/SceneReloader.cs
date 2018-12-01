using UnityEngine;
using UnityEngine.SceneManagement;

namespace Components {
	public class SceneReloader : MonoBehaviour {
		#region Public methods
		public void Reload() {
			Time.timeScale = 1;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		#endregion
	}
}