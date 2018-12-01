using UnityEngine;
using UnityEngine.Tilemaps;

namespace Components.Traps {
	public class Water : AbstractTrap {
		#region Private fields
		[SerializeField] private TileBase iceTile;
		[SerializeField] private Grid grid;
		[SerializeField] private Tilemap tilemap;
		
		private Collider2D coll;
		#endregion

		#region Protected fields
		protected new readonly string animationName = "Water";
		#endregion

		#region Life cycle
		private void Awake() {
			coll = GetComponent<Collider2D>();
		}
		#endregion
		
		#region Abstract Trap methods
		public override void Disable() {
			coll.isTrigger = false;

			var minPos = grid.WorldToCell(coll.bounds.min);
			var maxPos = grid.WorldToCell(coll.bounds.max);

			for (var y = minPos.y; y <= maxPos.y; y++) {
				for (var x = minPos.x; x <= maxPos.x; x++) {
					var tilePos = new Vector3Int(x, y, 0);
					tilemap.SetTile(tilePos, iceTile);
				}
			}
		}
		#endregion
	}
}