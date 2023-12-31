using Sirenix.OdinInspector;
using UnityEngine;

namespace PatataStudio.ARPG.Entity
{
	[System.Serializable]
	public struct StatBase
	{
		[ProgressBar(0, "Max", Height = 15)]
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