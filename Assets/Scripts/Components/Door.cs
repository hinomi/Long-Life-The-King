using UnityEngine;

namespace Components {
	[RequireComponent(typeof(AudioSource))]
	public class Door : MonoBehaviour {
		#region Private fields
		[SerializeField] private SpriteRenderer spriteRenderer;
		[SerializeField] private Sprite activeSprite;

		private AudioSource audioSource;
		#endregion

		#region Life cycle
		private void Awake() {
			audioSource = GetComponent<AudioSource>();
		}
		
		private void OnTriggerEnter2D(Collider2D coll) {
			if (!coll.CompareTag("Pawn")) return;
			
			spriteRenderer.sprite = activeSprite;
			audioSource.Play();
		}
		#endregion
	}
}