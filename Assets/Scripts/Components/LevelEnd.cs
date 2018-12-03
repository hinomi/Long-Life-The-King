using Components.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Components {
	[RequireComponent(typeof(AudioSource))]
	public class LevelEnd : MonoBehaviour {
		#region Private fields
		[SerializeField] private string nextLevel;
		[SerializeField] private Canvas canvas;
		[SerializeField] private int oneStarCount;
		[SerializeField] private int twoStarCount;
		[SerializeField] private int threeStarCount;
		[SerializeField] private Star firstStar;
		[SerializeField] private Star secondStar;
		[SerializeField] private Star thirdStar;
		[SerializeField] private Star specialStar;
		[SerializeField] private AudioClip endClip;
		[SerializeField] private AudioSource environmentAudio;

		private int deathCount;
		private AudioSource audioSource;
		#endregion

		#region Life cycle
		private void Awake() {
			audioSource = GetComponent<AudioSource>();
		}
		
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
				audioSource.clip = endClip;
				audioSource.Play();
				environmentAudio.Stop();
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