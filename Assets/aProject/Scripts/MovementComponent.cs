using UnityEngine;

namespace PatataStudio
{
	[RequireComponent(typeof(InputControllerBase))]
	public class MovementComponent : MonoBehaviour
	{
		[SerializeField] private StatBase moveSpeed;
		private InputControllerBase inputController;

		private void Start()
		{
			inputController = gameObject.GetComponent<InputControllerBase>();
		}

		private void Update()
		{

		}

		private void FixedUpdate()
		{

		}

		private void OnValidate()
		{
			moveSpeed.RecalculateStat();
		}
	}
}