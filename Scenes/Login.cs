using Godot;
using System;

public class Login : Control
{
    public TextureButton ExitButton;
    public TextureButton EnterButton;
    public TextureButton RegistrationButton;
    public TextureButton ForgotButton;

    public TextEdit LoginField;
    public TextEdit PasswordField;

    public override void _Ready()
    {
        ExitButton = GetNode<TextureButton>("Exit");
        EnterButton = GetNode<TextureButton>("Enter");
        RegistrationButton = GetNode<TextureButton>("REG");
        ForgotButton = GetNode<TextureButton>("ForgotButton");

        
    }

}
