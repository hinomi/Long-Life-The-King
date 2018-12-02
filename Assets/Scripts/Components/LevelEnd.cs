using Components.UI;
using Gamekit2D;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Components {
	public class LevelEnd : MonoBehaviour {
		#region Private fields
		[SerializeField, SceneName] private string nextLevel;
		[SerializeField] private Canvas canvas;
		[SerializeField] private int oneStarCount;
		[SerializeField] private int twoStarCount;
		[SerializeField] private int threeStarCount;
		[SerializeField] private Star firstStar;
		[SerializeField] private Star secondStar;
		[SerializeField] private Star thirdStar;
		[SerializeField] private Star specialStar;

		private int deathCount;
		#endregion

		#region Life cycle
		private void OnTriggerEnter2D(Collider2D coll) {
			if (coll.CompareTag("King")) {
				if (deathCount <= oneStarCount) {
					firstStar.Fill();

					if (deathCount <= twoStarCount) {
						secondStar.Fill();
						
						if (deathCount <= threeStarCount)
							thirdStar.Fill();
					}
				}
				
				Time.timeScale = 0;
				canvas.gameObject.SetActive(true);
			}
			else if (coll.CompareTag("Pawn")) {
				specialStar.Fill();
			}
		}
		#endregion

		#region Public methods
		public void LoadNextLevel() {
			Time.timeScale = 1;
			SceneManager.LoadScene(nextLevel);
		}
		
		public void IncrementDeathCount() {
			deathCount++;
		}
		#endregion
	}
}