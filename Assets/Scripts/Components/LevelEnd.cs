using Gamekit2D;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Components {
	public class LevelEnd : MonoBehaviour {
		#region Private fields
		[SerializeField, SceneName] private string nextLevel;
		[SerializeField] private Canvas canvas;
		#endregion

		#region Life cycle
		private void OnTriggerEnter2D(Collider2D coll) {
			Time.timeScale = 0;
			canvas.gameObject.SetActive(true);
		}
		#endregion

		#region Public methods
		public void LoadNextLevel() {
			Time.timeScale = 1;
			SceneManager.LoadScene(nextLevel);
		}
		#endregion
	}
}