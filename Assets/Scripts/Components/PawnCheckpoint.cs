using Components.DeathControllers;
using UnityEngine;

namespace Components {
	[RequireComponent(typeof(AudioSource))]
	public class PawnCheckpoint : MonoBehaviour {
		#region Private fields
		private AudioSource audioSource;
		private bool active = false;
		#endregion
		
		#region Life cycle
		private void Awake() {
			audioSource = GetComponent<AudioSource>();
		}
		
		private void OnTriggerEnter2D(Collider2D coll) {
			if (active) return;
			
			var deathController = coll.GetComponent<PawnDeathController>();
			if (deathController != null) {
				active = true;
				deathController.Spawner = transform;
				audioSource.Play();
			}
		}
		#endregion
	}
}