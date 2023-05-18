protected void grdwastage_DataBound(object sender, EventArgs e)
{
    GridView grid = (GridView)sender;

    foreach (GridViewRow row in grid.Rows)
    {
        foreach (Control ctrl in row.Controls)
        {
            if (ctrl is TextBox)
            {
                TextBox txt = (TextBox)ctrl;
                if (txt.Text == "0")
                {
                    txt.Text = "";
                }
            }
            else if (ctrl.Controls.Count > 0) // check if the control has child controls
            {
                FindTextBoxes(ctrl); // call the function recursively
            }
        }
    }
}

private void FindTextBoxes(Control parent)
{
    foreach (Control ctrl in parent.Controls)
    {
        if (ctrl is TextBox)
        {
            TextBox txt = (TextBox)ctrl;
            if (txt.Text == "0")
            {
                txt.Text = "";
            }
        }
        else if (ctrl.Controls.Count > 0)
        {
            FindTextBoxes(ctrl);
        }
    }
}
