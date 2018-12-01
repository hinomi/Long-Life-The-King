using UnityEngine;
using UnityEngine.Tilemaps;

namespace Components.Traps {
	public class Water : AbstractTrap {
		#region Private fields
		[SerializeField] private LayerMask newLayer;
		[SerializeField] private TileBase iceTile;
		[SerializeField] private GameObject tilemap;
		
		private Collider2D coll;
		private Grid grid;
		private Tilemap map;
		#endregion

		#region Life cycle
		private void Awake() {
			coll = GetComponent<Collider2D>();
			grid = tilemap.GetComponentInChildren<Grid>();
			map = tilemap.GetComponentInChildren<Tilemap>();
		}
		#endregion
		
		#region Abstract Trap methods
		public override void Disable() {
			coll.isTrigger = false;
			gameObject.layer = newLayer;

			var minPos = grid.WorldToCell(coll.bounds.min);
			var maxPos = grid.WorldToCell(coll.bounds.max);

			for (var y = minPos.y; y <= maxPos.y; y++) {
				for (var x = minPos.x; x <= maxPos.x; x++) {
					var tilePos = new Vector3Int(x, y, 0);
					map.SetTile(tilePos, iceTile);
				}
			}
		}
		#endregion
	}
}