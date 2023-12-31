using PatataStudio.Utils.Extensions;
using UnityEngine;

namespace PatataStudio.ARPG.Entity
{
	public class MovementComponent : MonoBehaviour
	{
		[SerializeField] private StatBase moveSpeed;
		private Rigidbody2D rb2D;

		private void Start()
		{
			rb2D = gameObject.GetOrAdd<Rigidbody2D>();
		}

		public void Move(Vector2 movement)
		{
			rb2D.transform.Translate(movement * moveSpeed.Current * Time.deltaTime);
		}

		private void OnValidate()
		{
			moveSpeed.RecalculateStat();
		}
	}
}