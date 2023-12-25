using UnityEngine;

namespace PatataStudio
{
	[RequireComponent(typeof(IInputController))]
	public class MovementComponent : MonoBehaviour
	{
		[SerializeField] private StatBase moveSpeed;
		private IInputController inputController;

		private void Start()
		{
			inputController = gameObject.GetComponent<IInputController>();
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