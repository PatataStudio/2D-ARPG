using PatataStudio.Utils.Extensions;
using UnityEngine;
using UnityEngine.UIElements;

namespace PatataStudio
{
	public class MovementComponent : MonoBehaviour
	{
		[SerializeField] private StatBase moveSpeed;
		private Rigidbody2D rb2D;

		private void Start()
		{
			rb2D = gameObject.GetOrAddComponent<Rigidbody2D>();
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