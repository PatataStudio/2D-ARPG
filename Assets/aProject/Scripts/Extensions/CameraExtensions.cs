using UnityEngine;

namespace PatataStudio.Utils
{
	public static class CameraExtensions
	{
		/// <summary>
		/// Calculates and returns viewport extents with an optional margin. Useful for calculating a frustum for culling.
		/// </summary>
		/// <param name="camera">The camera object this method extends.</param>
		/// <param name="viewportMargin">Optional margin to be applied to viewport extents. Default is 0.2, 0.2.</param>
		/// <returns>Viewport extents as a Vector2 after applying the margin.</returns>
		public static Vector2 GetViewportExtentsWithMargin(this Camera camera, Vector2? viewportMargin = null)
		{
			Vector2 _margin = viewportMargin ?? new Vector2(0.2f, 0.2f);
			Vector2 _result;
			float _halfFieldOfView = camera.fieldOfView * 0.5f * Mathf.Deg2Rad;
			_result.y = camera.nearClipPlane * Mathf.Tan(_halfFieldOfView);
			_result.x = _result.y * camera.aspect + _margin.x;
			_result.y += _margin.y;
			return _result;

		}
	}
}