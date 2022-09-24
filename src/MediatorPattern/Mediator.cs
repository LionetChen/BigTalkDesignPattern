using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern;
public class Mediator
{
    public Button btnAction { get; private set; }
    public CheckBox chkIsExistingUser { get; private set; }
    public TextBox txtUsername { get; private set; }

    public string LastAction { get; private set; } = string.Empty;

    public Mediator()
    {
        btnAction = new Button(this, "Login", nameof(btnAction));
        chkIsExistingUser = new CheckBox(this, "Is existing user", nameof(chkIsExistingUser));
        txtUsername = new TextBox(this, "Username", nameof(txtUsername));

        btnAction.Clicked += BtnAction_Clicked;
        chkIsExistingUser.CheckChanged += ChkIsExistingUser_CheckChanged;

        chkIsExistingUser.SetStatus(false);
    }

    private void ChkIsExistingUser_CheckChanged(CheckBox sender, bool isChecked)
    {
        btnAction.Text = isChecked ? "Login" : "Register";
    }

    private void BtnAction_Clicked(Component sender)
    {
        LastAction = ($"{sender.Name} is showing {sender.Text}. Username = {txtUsername.Text}");
    }
}
