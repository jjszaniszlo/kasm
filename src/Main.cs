using Godot;

namespace NightmareNegotiations;

public partial class Main : Node3D
{
	private PackedScene usernamePromptTemplate = GD.Load<PackedScene>("res://scenes/UsernamePrompt/UsernamePrompt.tscn");
	
	public override void _Ready()
	{
		AddChild(usernamePromptTemplate.Instantiate());
	}
}