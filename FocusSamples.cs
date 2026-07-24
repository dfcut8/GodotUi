using Godot;

public partial class FocusSamples : Control
{
    private Button? focusedButton;
    private Label? label;
    public override void _Ready()
    {
        focusedButton = GetNode<Button>("%Button4");
        label = GetNode<Label>("%Label");
        focusedButton?.GrabFocus();
        focusedButton?.FocusEntered += OnFocusEntered;
    }

    private void OnFocusEntered()
    {
        GD.Print("Focus Entered!");
        label?.Text = focusedButton?.HasFocus().ToString();
    }

    public override void _Process(double delta) { }
}
