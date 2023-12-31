using UnityEngine;
using UnityEngine.Rendering;

namespace PatataStudio.Utils.Extensions
{
	public static class VolumeExtensions
	{
		/// <summary>
		/// Loads Volume Profile from given path.
		/// </summary>
		/// <param name="volume">Volume Profile for loading</param>
		/// <param name="path">Path to Volume Profile to be loaded</param>
		public static void LoadVolumeProfile (this Volume volume, string path)
		{
			var _profile = Resources.Load<VolumeProfile>(path);
			volume.profile = _profile;
		}
	}
}