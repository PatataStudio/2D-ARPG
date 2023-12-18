using NaughtyAttributes;
using UnityEngine;

namespace PatataStudio
{
	[System.Serializable]
	public struct StatBase
	{
		[ProgressBar("Value", "Max")]
		public float Current;
		[HideInInspector] public float Max;
		public float Base;
		public float Multiplier;
		public float Additive;

		public void RecalculateStat()
		{
			Max = (Base * Multiplier) + Additive;
			Current = Max;
		}
	}
}