using UnityEngine;

namespace PatataStudio.ARPG.Entity
{
	public class StatsComponent : MonoBehaviour
	{
		[SerializeField] private StatBase Health;
		[SerializeField] private StatBase HealthRegen;
		[SerializeField] private StatBase Mana;
		[SerializeField] private StatBase ManaRegen;
		[SerializeField] private StatBase Defences;

		void Start()
		{
			RecalculateStats();
		}

		void Update()
		{

		}

		private void RecalculateStats()
		{
			Health.RecalculateStat();
			HealthRegen.RecalculateStat();
			Mana.RecalculateStat();
			ManaRegen.RecalculateStat();
			Defences.RecalculateStat();
		}

		private void OnValidate()
		{
			RecalculateStats();
		}
	}
}