using UnityEngine;

public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelecatable
{
	public float Health => _health;
	public float MaxHealth => _maxHealth;
	public Sprite Icon => _icon;
	public Transform PivotPoint => _pivotPoint;


	[SerializeField] private Transform _unitsParent;

	[SerializeField] private float _maxHealth = 1000;
	[SerializeField] private Sprite _icon;
	[SerializeField] private Transform _pivotPoint;

	private float _health = 1000;

	public override void ExecuteSpecificCommand(IProduceUnitCommand command)
	{
		Instantiate(command.UnitPrefab, new Vector3(Random.Range(-3, 3), 0, Random.Range(0, 7)), Quaternion.identity, _unitsParent);
	}

}

